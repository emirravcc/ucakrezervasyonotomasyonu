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
    public partial class FormGiriş : Form
    {
        public FormGiriş()
        {
            InitializeComponent();
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = textEditKullanıcıAdı.Text;
            string parola = textEditParola.Text;

            if (Veritabanı.Instance.KullanıcıGiris(kullanıcıAdı, parola))
            {
                MessageBox.Show("test");

            }

        }

        private void linkLabelHesapOluşturma_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
        }
    }
}
