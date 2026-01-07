using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakRezervasyonOtomasyon
{
    public partial class KoltukSecimi : Form
    {


        private PictureBox sonSecilenKoltuk; // Son seçilen koltuğu saklamak için
        private int seferID;
        private int ücret;
        public KoltukSecimi(int seferID, int ücret)
        {
            this.seferID = seferID;
            this.ücret = ücret;
            InitializeComponent();
        }

        private void buttonDevamEt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelSeçilenKoltuk.Text) || labelSeçilenKoltuk.Text == "Seçilen Koltuk:")
            {
                MessageBox.Show("Lütfen bir koltuk seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = labelSeçilenKoltuk.Text.IndexOf(":");
            string selectedSeat = labelSeçilenKoltuk.Text.Substring(index + 2);



            // Ödeme formuna yönlendir
            this.Hide();
            ÖdemeForm ödemeForm = new ÖdemeForm(seferID, selectedSeat, ücret);
            ödemeForm.Show();
        }




        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedPictureBox)
            {
                // Daha önce seçilmiş bir koltuk varsa, resmini boş koltuk resmiyle değiştir
                if (sonSecilenKoltuk != null && sonSecilenKoltuk != clickedPictureBox)
                {
                    sonSecilenKoltuk.Image = Properties.Resources.boşkoltuk;
                }

                // Yeni seçilen koltuğu güncelle
                clickedPictureBox.Image = Properties.Resources.dolukoltuk;
                sonSecilenKoltuk = clickedPictureBox; // Son seçili koltuğu güncelle

                // Label'i güncelle
                labelSeçilenKoltuk.Text = "Seçilen Koltuk: " + clickedPictureBox.Name;
            }
        }

        private void KoltukSecimi_Load(object sender, EventArgs e)
        {
            // Tüm koltukları kontrol et
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    // Click olayını bağla
                    pictureBox.Click += PictureBox_Click;
                    pictureBox.Image = Properties.Resources.boşkoltuk; // Varsayılan olarak boş koltuk resmi
                }
            }

            // Veritabanından dolu koltukları al
            List<string> doluKoltuklar = GetDoluKoltuklar(seferID);

            // Dolu koltukları işaretle
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pictureBox && doluKoltuklar.Contains(pictureBox.Name))
                {
                    pictureBox.Image = Properties.Resources.satınalınmışkoltuk; // Dolu koltuk resmi
                    pictureBox.Enabled = false; // Seçilemez hale getir
                }
            }
        }


        private List<string> GetDoluKoltuklar(int seferID)
        {
            List<string> doluKoltuklar = new List<string>();

            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT koltuk_no FROM koltuklar WHERE sefer_id = @SeferID AND durum = TRUE";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SeferID", seferID);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            doluKoltuklar.Add(reader["koltuk_no"].ToString());
                        }
                    }
                }
            }

            return doluKoltuklar;
        }








    }
}
