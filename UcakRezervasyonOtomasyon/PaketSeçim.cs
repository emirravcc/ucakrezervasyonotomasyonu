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
    public partial class PaketSeçim : Form
    {
        private int seferID;
        public PaketSeçim(int seferID)
        {
            this.seferID = seferID;
            InitializeComponent();
        }

        private void süperEko_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            new KoltukSecimi(seferID, 2500).Show();
        }

        private void avantaj_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            new KoltukSecimi(seferID, 3100).Show();

        }

        private void comfortflex_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            new KoltukSecimi(seferID, 4850).Show();

        }
    }
}
