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

namespace UcakRezervasyonOtomasyon
{
    public partial class ucBiletSatınAl : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucBiletSatınAl _instance;

        public static ucBiletSatınAl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBiletSatınAl();
                return _instance;
            }
        }
        public ucBiletSatınAl()
        {

            InitializeComponent();
          //  labelDönüşTarihi.Visible = false;
          //  dateDönüş.Visible = false;
            radioTekYon.Enabled = true;
            LoadIller();
           // labelAktifSeferler.Visible = false;
           // checkedListAktifSeferler.Visible = false;


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
                comboNereye.Properties.Items.Add(il);
                comboNereden.Properties.Items.Add(il);

            }
        }

        private void ucBiletSatınAl_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonSeferKontrol_Click(object sender, EventArgs e)
        {
            if (!radioGidisDonus.Checked && !radioTekYon.Checked)
            {
                MessageBox.Show("Bir gidiş yönü seçiniz.");
                return;
            }


            // Gidiş Tarihi'ni almak için
            DateTime gidisTarihi = dateGidiş.EditValue != null ? (DateTime)dateGidiş.EditValue : DateTime.Now;
            DateTime donusTarihi = dateDönüş.EditValue != null ? (DateTime)dateDönüş.EditValue : DateTime.Now;


            // Nereye seçilen yeri almak için
            string nereye = comboNereye.SelectedItem.ToString();

            // Nereden seçilen yeri almak için
            string nereden = comboNereden.SelectedItem.ToString();


            if (radioGidisDonus.Checked && radioTekYon.Checked)
            {
                MessageBox.Show("Tek Yön ve Gidiş - Dönüş aynı anda seçilemez.");
                return;
            }
            else
            {


                Sefer seferr = new Sefer();


                if (radioTekYon.Checked)
                {

                    List<Sefer> seferler = seferr.GetSeferler(gidisTarihi, nereden, nereye);

                    if (seferler.Count == 0)
                    {
                        MessageBox.Show("Kriterlere uygun sefer bulunamadı.");
                        return;
                    }

                    int j = 0;
                    foreach (var sefer in seferler)
                    {

                        if (sefer.SeferTipi.Equals("Gidiş"))
                        {
                            checkedListAktifSeferler.Items.Add($"{sefer.Id} - {sefer.Nereden} -> {sefer.Nereye} ({sefer.TarihGidis:yyyy-MM-dd HH:mm})");
                            j++;

                        }


                        if (j != 0)
                        {
                            labelAktifSeferler.Visible = true;
                            checkedListAktifSeferler.Visible = true;
                        }




                    }
                }

                if (radioGidisDonus.Checked)
                {

                    List<Sefer> seferler = seferr.GetGidisDonusSeferler(gidisTarihi, donusTarihi, nereden, nereye);

                    if (seferler.Count == 0)
                    {
                        MessageBox.Show("Kriterlere uygun sefer bulunamadı.");
                        return;
                    }

                    if (seferler.Count != 0)
                    {
                        labelAktifSeferler.Visible = true;
                        checkedListAktifSeferler.Visible = true;
                    }


                    foreach (var sefer in seferler)
                    {
                        if (sefer.SeferTipi.Equals("Gidiş-Dönüş"))
                        {


                            checkedListAktifSeferler.Items.Add($"{sefer.Id} - {sefer.Nereden} -> {sefer.Nereye} ({sefer.TarihGidis:yyyy-MM-dd HH:mm}) - Dönüş -> ({sefer.TarihDonus:yyyy-MM-dd HH:mm})");
                        }
                    }




                }
            }



        }



        private int? GetSelectedSeferId()
        {
            // Seçili öğeleri kontrol et
            var selectedItems = checkedListAktifSeferler.CheckedItems;
            if (selectedItems.Count != 1) // Sadece bir tane seçili olmalı
            {
                MessageBox.Show("Lütfen sadece bir sefer seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Seçili öğeyi al
            string selectedItem = selectedItems[0].ToString();

            // Sefer ID'sini al (örnek: "1 - İstanbul -> Ankara")
            int firstDashIndex = selectedItem.IndexOf(" -");
            if (firstDashIndex != -1)
            {
                string idStr = selectedItem.Substring(0, firstDashIndex).Trim();
                if (int.TryParse(idStr, out int seferID))
                {
                    return seferID; // Sefer ID'sini döndür
                }
            }

            MessageBox.Show("Geçersiz formatta sefer bilgisi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }



        private void radioGidisDonus_CheckedChanged(object sender, EventArgs e)
        {
         //   labelDönüşTarihi.Visible = true;
         //   dateDönüş.Visible = true;


        }

        private void radioTekYon_CheckedChanged(object sender, EventArgs e)
        {
          //  labelDönüşTarihi.Visible = false;
          //  dateDönüş.Visible = false;
        }

        private void tileBar1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            int? selectedSeferId = GetSelectedSeferId();
            if (selectedSeferId.HasValue)
            {
                //this.Hide();
                new PaketSeçim(selectedSeferId.Value).Show();

            }

        }
    }
}
