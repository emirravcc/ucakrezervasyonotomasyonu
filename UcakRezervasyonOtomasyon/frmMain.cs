using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UcakRezervasyonOtomasyon
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
            //this.Hide();
           // new ucGirişSayfası().Show();
        }


        /*
        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            if(!containeryeni.Controls.Contains(ucBiletSatınAl.Instance))
            {
                container.Controls.Add(ucBiletSatınAl.Instance);
                ucBiletSatınAl.Instance.Dock = DockStyle.Fill;
                ucBiletSatınAl.Instance.BringToFront();
            }
            ucBiletSatınAl.Instance.BringToFront();

        }

        private void aceSeheyatBilgilendirme_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucSeheyatBilgilendirmesi.Instance))
            {
                container.Controls.Add(ucSeheyatBilgilendirmesi.Instance);
                ucSeheyatBilgilendirmesi.Instance.Dock = DockStyle.Fill;
                ucSeheyatBilgilendirmesi.Instance.BringToFront();
            }
            ucSeheyatBilgilendirmesi.Instance.BringToFront();

        }

        private void aceSeheyatDeneyim_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucSeheyatDeneyimi.Instance))
            {
                container.Controls.Add(ucSeheyatDeneyimi.Instance);
                ucSeheyatDeneyimi.Instance.Dock = DockStyle.Fill;
                ucSeheyatDeneyimi.Instance.BringToFront();
            }
            ucSeheyatDeneyimi.Instance.BringToFront();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {

        }

        private void accordionControlElementBilgiGüncelleme_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucBilgiGüncelleme.Instance))
            {
                container.Controls.Add(ucBilgiGüncelleme.Instance);
                ucBilgiGüncelleme.Instance.Dock = DockStyle.Fill;
                ucBilgiGüncelleme.Instance.BringToFront();
            }
            ucBilgiGüncelleme.Instance.BringToFront();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucSeferEkle.Instance))
            {
                container.Controls.Add(ucSeferEkle.Instance);
                ucSeferEkle.Instance.Dock = DockStyle.Fill;
                ucSeferEkle.Instance.BringToFront();
            }
            ucSeferEkle.Instance.BringToFront();
        }
        */

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {
            if (!containeryeni.Controls.Contains(ucBiletSatınAl.Instance))
            {
                containeryeni.Controls.Add(ucBiletSatınAl.Instance);
                ucBiletSatınAl.Instance.Dock = DockStyle.Fill;
                ucBiletSatınAl.Instance.BringToFront();
            }
            ucBiletSatınAl.Instance.BringToFront();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            if (!containeryeni.Controls.Contains(ucSeheyatBilgilendirmesi.Instance))
            {
                containeryeni.Controls.Add(ucSeheyatBilgilendirmesi.Instance);
                ucSeheyatBilgilendirmesi.Instance.Dock = DockStyle.Fill;
                ucSeheyatBilgilendirmesi.Instance.BringToFront();
            }
            ucSeheyatBilgilendirmesi.Instance.BringToFront();
        }

        private void accordionControlElementUçuşDeneyimi_Click(object sender, EventArgs e)
        {
            if (!containeryeni.Controls.Contains(ucSeheyatDeneyimi.Instance))
            {
                containeryeni.Controls.Add(ucSeheyatDeneyimi.Instance);
                ucSeheyatDeneyimi.Instance.Dock = DockStyle.Fill;
                ucSeheyatDeneyimi.Instance.BringToFront();
            }
            ucSeheyatDeneyimi.Instance.BringToFront();
        }

        private void accordionControlElementKişiselBilgiler_Click(object sender, EventArgs e)
        {

            if (!containeryeni.Controls.Contains(ucBilgiGüncelleme.Instance))
            {
                containeryeni.Controls.Add(ucBilgiGüncelleme.Instance);
                ucBilgiGüncelleme.Instance.Dock = DockStyle.Fill;
                ucBilgiGüncelleme.Instance.BringToFront();
            }
            ucBilgiGüncelleme.Instance.BringToFront();

        }

        private void accordionControlElementUçuşYönetimi_Click(object sender, EventArgs e)
        {


            if (!containeryeni.Controls.Contains(ucSeferEkle.Instance))
            {
                containeryeni.Controls.Add(ucSeferEkle.Instance);
                ucSeferEkle.Instance.Dock = DockStyle.Fill;
                ucSeferEkle.Instance.BringToFront();
            }
            ucSeferEkle.Instance.BringToFront();

        }

        private void accordionControlElementAnaSayfa_Click(object sender, EventArgs e)
        {
            if (!containeryeni.Controls.Contains(ucBiletSatınAl.Instance))
            {
                containeryeni.Controls.Add(ucBiletSatınAl.Instance);
                ucBiletSatınAl.Instance.Dock = DockStyle.Fill;
                ucBiletSatınAl.Instance.BringToFront();
            }
            ucBiletSatınAl.Instance.BringToFront();
        }

        private void accordionControlElementBiletlerim_Click(object sender, EventArgs e)
        {
            if (!containeryeni.Controls.Contains(ucUçuşlarım.Instance))
            {
                containeryeni.Controls.Add(ucUçuşlarım.Instance);
                ucUçuşlarım.Instance.Dock = DockStyle.Fill;
                ucUçuşlarım.Instance.BringToFront();
            }
            ucUçuşlarım.Instance.BringToFront();
        }


        // Kullanıcı Yönetimi
        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            if (!containeryeni.Controls.Contains(ucKullanıcıYönetimi.Instance))
            {
                containeryeni.Controls.Add(ucKullanıcıYönetimi.Instance);
                ucKullanıcıYönetimi.Instance.Dock = DockStyle.Fill;
                ucKullanıcıYönetimi.Instance.BringToFront();
            }
            ucKullanıcıYönetimi.Instance.BringToFront();

        }

        private void H_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElementDeneyimRaporları_Click(object sender, EventArgs e)
        {
            if (!containeryeni.Controls.Contains(ucDeneyimRaporları.Instance))
            {
                containeryeni.Controls.Add(ucDeneyimRaporları.Instance);
                ucDeneyimRaporları.Instance.Dock = DockStyle.Fill;
                ucDeneyimRaporları.Instance.BringToFront();
            }
            ucDeneyimRaporları.Instance.BringToFront();
        }

        private void y_Click(object sender, EventArgs e)
        {
            if (!containeryeni.Controls.Contains(ucBiletSatınAl.Instance))
            {
                containeryeni.Controls.Add(ucBiletSatınAl.Instance);
                ucBiletSatınAl.Instance.Dock = DockStyle.Fill;
                ucBiletSatınAl.Instance.BringToFront();
            }
            ucBiletSatınAl.Instance.BringToFront();
        }
    }
}