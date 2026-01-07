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
    public partial class ucKayıtSayfası : Form
    {

        private static ucKayıtSayfası _instance;

        public static ucKayıtSayfası Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucKayıtSayfası();
                return _instance;
            }
        }

        public ucKayıtSayfası()
        {
            InitializeComponent();
        }

        private void simpleButtonKayıtOl_Click(object sender, EventArgs e)
        {
            string epostaAdresi = textEditEposta.Text;
            string kullanıcıAdı = textEditKullanıcıAdı.Text;
            string parola = textEditParola.Text;


            string tc = textEditTC.Text;
            string isim = textEditİsim.Text;
            string soyisim = textEditSoyİsim.Text;
            string cinsiyet = textEditCinsiyet.Text;
            string telefon = textEditTelefon.Text;
            DateTime doğumTarihi = dateEditDoğumTarihi.EditValue != null ? (DateTime)dateEditDoğumTarihi.EditValue : DateTime.Now;

            Kullanıcı kullanıcı = new Kullanıcı(kullanıcıAdı, epostaAdresi, parola, tc, isim, soyisim, cinsiyet, telefon, doğumTarihi, "false");
               

            Veritabanı.Instance.KullanıcıEkle(kullanıcı);


            MessageBox.Show("Kayıt işlemi başarılı.");
            this.Hide();
            ucGirişSayfası.Instance.Show();

        }
    }
}
