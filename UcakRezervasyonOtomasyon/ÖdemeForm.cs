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
    public partial class ÖdemeForm : Form
    {
        string KoltukNumarası { get; set; }
        private int seferID;
        private int ücret;


        public ÖdemeForm(int seferID, String koltukNumarası, int ücret)
        {
            this.seferID = seferID;
            KoltukNumarası = koltukNumarası;
            this.ücret = ücret;
            InitializeComponent();
            simpleButtonÖdemeYap.Text = "Ödeme Yap (" + ücret + "TL )";

        }

        private void simpleButtonÖdemeYap_Click(object sender, EventArgs e)
        {
            string kartBilgileri = textEditKartNumarası.Text;
            string sonKullanmaTarihi = textEditSonKullanmaTarihi.Text;
            string cvc2 = textEditCVC2.Text;
            Ödemeİşlemi();
            this.Hide();


        }



        public void Ödemeİşlemi()
        {
            MessageBox.Show("Başarıyla " + seferID + " uçuş numaralı biletinizde " + KoltukNumarası + " koltuk numarasını satın aldınız.", "Bilet Satın Alım Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            ÖdemeYönetimi ödemeYönetimi = new ÖdemeYönetimi();
            Ödeme yeniÖdeme = new Ödeme
            {
                SeferID = seferID,           // Örnek sefer ID
                KoltukNo = KoltukNumarası,       // Seçilen koltuk
                ÖdemeTutarı = ücret, // Ödeme tutarı
                MüşteriID = KullanıcıYönetimi.Instance.GirişYapanKullanıcı.Id         // Kullanıcılar tablosundaki müşteri ID
            };

            ödemeYönetimi.ÖdemeEkle(yeniÖdeme);
            Veritabanı.Instance.koltukGüncelle(seferID, KoltukNumarası);



        }
    }
}
