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
    public partial class ucSeheyatDeneyimi : DevExpress.XtraEditors.XtraUserControl
    {

        private static ucSeheyatDeneyimi _instance;

        public static ucSeheyatDeneyimi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSeheyatDeneyimi();
                return _instance;
            }
        }


        public ucSeheyatDeneyimi()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string adıSoyadı = textEditAdıSoyadı.Text;
            string eposta = textEditEposta.Text;
            string telefonno = textEditTelefon.Text;
            string seferNo = textEditSeferNumarası.Text;
            string deneyim = richTextBoxDeneyim.Text;


            Veritabanı.Instance.DeneyimEkle(adıSoyadı, eposta, telefonno, Convert.ToInt32(seferNo), deneyim);
            MessageBox.Show("Geri dönüş gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
