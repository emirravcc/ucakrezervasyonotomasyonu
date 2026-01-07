using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySqlConnector;

namespace UcakRezervasyonOtomasyon
{
    public partial class ucSeferEkle : DevExpress.XtraEditors.XtraUserControl
    {

        private static ucSeferEkle _instance;

        public static ucSeferEkle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSeferEkle();
                return _instance;
            }
        }


        public ucSeferEkle()
        {
            InitializeComponent();
            dateEditSeferGidiş.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            dateEditSeferGidiş.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButtonGidiş.CheckedChanged += RadioButton_CheckedChanged;
            LoadIller();
            updateTablo();

        }

        private void LoadIller()
        {
            // Türkiye'nin tüm illerini bir liste olarak tanımlıyoruz
            List<string> iller = new List<string>
            {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya",
                "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu",
                "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır",
                "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep",
                "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul",
                "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri",
                "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya",
                "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde",
                "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Şanlıurfa", "Siirt", "Sinop",
                "Şırnak", "Sivas", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van",
                "Yalova", "Yozgat", "Zonguldak"
            };

            // ComboBoxEdit'in Items özelliğine illeri ekliyoruz
            foreach (string il in iller)
            {
                comboBoxEditSeferNereden.Properties.Items.Add(il);
                comboBoxEditSeferNereye.Properties.Items.Add(il);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
  
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // RadioButton1 seçildiyse DateTime düzenlenebilir hale gelir
            if (radioButton1.Checked)
            {
                dateEditDönüş.Properties.ReadOnly = false; // Düzenlenebilir
                radioButtonGidiş.Checked = false;
            }
            else
            {
                dateEditDönüş.Properties.ReadOnly = true; // Düzenlenemez
                radioButtonGidiş.Checked = true;

            }
        }


        private string getSelectedSeferTipi()
        {
            if (radioButton1.Checked)
            {
                return "Gidiş-Dönüş";
            }
            if (radioButtonGidiş.Checked)
            {
                return "Gidiş";
            }
            return null;
        }

        private void buttonSeferEkle_Click(object sender, EventArgs e)
        {
            string nereden = comboBoxEditSeferNereden.SelectedItem?.ToString();
            string nereye = comboBoxEditSeferNereye.SelectedItem?.ToString();
            string seferTipi = getSelectedSeferTipi();


            DateTime gidisTarihi = dateEditSeferGidiş.EditValue != null
            ? (DateTime)dateEditSeferGidiş.EditValue
            : DateTime.Now.Date.AddHours(9); // Varsayılan olarak sabah 9:00

            DateTime? dönüşTarihi = dateEditDönüş.EditValue as DateTime?;


            Veritabanı.Instance.SeferOlustur(nereden, nereye, seferTipi, gidisTarihi, dönüşTarihi);


            MessageBox.Show("Başarıyla Sefer Eklendi.");
            updateTablo();



        }


        private void updateTablo()
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {

                // Seferleri çekmek için SQL sorgusu
                var command = new MySqlCommand("SELECT id, nereden, nereye, seferTipi, tarihGidiş, tarihDönüş FROM seferler", connection);
                MySqlDataReader reader = command.ExecuteReader();

                // CheckedListBoxControl'un sıfırlanması
                checkedListBoxControlSeferListesi.Items.Clear();

                // Veritabanından çekilen her seferi CheckedListBox'a ekleme
                while (reader.Read())
                {
                    int seferId = reader.GetInt32("id");
                    string nereden = reader.GetString("nereden");
                    string nereye = reader.GetString("nereye");
                    string seferTipi = reader.GetString("seferTipi");
                    DateTime tarihGidis = reader.GetDateTime("tarihGidiş");
                    DateTime? tarihDonus = reader.IsDBNull(reader.GetOrdinal("tarihDönüş")) ? (DateTime?)null : reader.GetDateTime("tarihDönüş");

                    string seferBilgisi = $"{seferId} - {nereden} - {nereye} ({seferTipi}) | Gidiş: {tarihGidis.ToShortDateString()}";

                    // Eğer dönüş tarihi varsa, ekleyelim
                    if (tarihDonus.HasValue)
                    {
                        seferBilgisi += $" | Dönüş: {tarihDonus.Value.ToShortDateString()}";
                    }

                    // Seferi CheckedListBox'a ekle
                    checkedListBoxControlSeferListesi.Items.Add(seferBilgisi, false); // false: başlangıçta seçili olmasın
                }
            }
        }


        private void SilSecilenSeferler()
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                // Seçili öğeleri tespit et
                var selectedItems = checkedListBoxControlSeferListesi.CheckedItems;
                if (selectedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek için en az bir sefer seçin.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var item in selectedItems)
                {
                    // Sefer bilgilerini parçalayarak ID'yi alın (örnek: "1 - İstanbul - Ankara")
                    string selectedItem = item.ToString();
                    int firstDashIndex = selectedItem.IndexOf(" -");
                    if (firstDashIndex == -1)
                        continue;

                    string idStr = selectedItem.Substring(0, firstDashIndex).Trim();
                    if (int.TryParse(idStr, out int seferID))
                    {
                        // Önce koltukları sil
                        string deleteKoltukQuery = "DELETE FROM koltuklar WHERE sefer_id = @SeferID";
                        using (var command = new MySqlCommand(deleteKoltukQuery, connection))
                        {
                            command.Parameters.AddWithValue("@SeferID", seferID);
                            command.ExecuteNonQuery();
                        }

                        // Ardından seferi sil
                        string deleteSeferQuery = "DELETE FROM seferler WHERE id = @SeferID";
                        using (var command = new MySqlCommand(deleteSeferQuery, connection))
                        {
                            command.Parameters.AddWithValue("@SeferID", seferID);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                // Listeyi güncelle
                updateTablo();
                MessageBox.Show("Seçili seferler başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void buttonSeferSil_Click(object sender, EventArgs e)
        {
            SilSecilenSeferler();
        }
    }
}
