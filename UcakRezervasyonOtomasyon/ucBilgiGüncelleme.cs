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
    public partial class ucBilgiGüncelleme : DevExpress.XtraEditors.XtraUserControl
    {

        private static ucBilgiGüncelleme _instance;

        public static ucBilgiGüncelleme Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBilgiGüncelleme();
                return _instance;
            }
        }


        public ucBilgiGüncelleme()
        {
            InitializeComponent();
            BilgileriGetir();
        }



        public void BilgileriGetir()
        {
            Kullanıcı kullanıcı = KullanıcıYönetimi.Instance.GirişYapanKullanıcı;
            textEditTC.Text = kullanıcı.Tc;
            textEditİsim.Text = kullanıcı.Isim;
            textEditSoyad.Text = kullanıcı.SoyAd;
            textEditCinsiyet.Text = kullanıcı.Cinsiyet;
            textEditTelefon.Text = kullanıcı.Telefon;
            textEditEposta.Text = kullanıcı.EpostaAdresi;
            dateEditDoğumTarihi.DateTime = kullanıcı.DoğumTarihi;
            

        }

        private void simpleButtonGüncelle_Click(object sender, EventArgs e)
        {
            string tc = textEditTC.Text;
            string isim = textEditİsim.Text;
            string soyad = textEditCinsiyet.Text;
            string cinsiyet = textEditCinsiyet.Text;
            string telefon = textEditTelefon.Text;
            string eposta = textEditEposta.Text;
            DateTime doğumTarihi = dateEditDoğumTarihi.EditValue != null ? (DateTime)dateEditDoğumTarihi.EditValue : DateTime.Now;

            string kullanıcıAdı = KullanıcıYönetimi.Instance.GirişYapanKullanıcı.KullanıcıAdı;
            string şifre = KullanıcıYönetimi.Instance.GirişYapanKullanıcı.Parola;


            Kullanıcı düzenlenmişKullanıcı = new Kullanıcı(kullanıcıAdı, eposta, şifre, tc, isim, soyad, cinsiyet, telefon, doğumTarihi, "false");
            KullanıcıYönetimi.Instance.GirişYapanKullanıcıyıAyarla(düzenlenmişKullanıcı);
            Veritabanı.Instance.KullanıcıGüncelle(düzenlenmişKullanıcı);
            MessageBox.Show("Başarıyla kullanıcı bilgilerini güncellediniz.");
                



          //  Kullanıcı kullanıcı = new Kullanıcı()
            


        }
    }
}
