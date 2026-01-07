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
    public partial class ucGirişSayfası : Form
    {

        private static ucGirişSayfası _instance;

        public static ucGirişSayfası Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucGirişSayfası();
                return _instance;
            }
        }

        public ucGirişSayfası()
        {
            InitializeComponent();
        }

        private void linkLabelHesapOluşturma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ucKayıtSayfası.Instance.Show();
           
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = textEditKullanıcıAdı.Text;
            string parola = textEditParola.Text;

            if (Veritabanı.Instance.KullanıcıGiris(kullanıcıAdı, parola))
            {
                this.Hide();
                Kullanıcı kullanıcı = Veritabanı.Instance.KullanıcıBilgileriniGetir(kullanıcıAdı);
                KullanıcıYönetimi.Instance.GirişYapanKullanıcıyıAyarla(kullanıcı);

                new frmMain().Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri yanlış lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
