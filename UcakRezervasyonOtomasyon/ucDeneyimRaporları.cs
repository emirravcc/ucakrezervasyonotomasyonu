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
    public partial class ucDeneyimRaporları : DevExpress.XtraEditors.XtraUserControl
    {

        private static ucDeneyimRaporları _instance;

        public static ucDeneyimRaporları Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDeneyimRaporları();
                return _instance;
            }
        }

        public ucDeneyimRaporları()
        {
            InitializeComponent();
        }

        private void ucDeneyimRaporları_Load(object sender, EventArgs e)
        {
            // Deneyim listesini çekiyoruz.
            var deneyimler = Veritabanı.Instance.DeneyimleriGetir();

            // Önce CheckedListBox'ı temizliyoruz.
            checkedListBoxControlDeneyimler.Items.Clear();

            // Her bir deneyimi CheckedListBox'a ekliyoruz.
            foreach (var deneyim in deneyimler)
            {
                string item = $"Ad Soyad: {deneyim.AdSoyad}, E-posta: {deneyim.EpostaAdresi}, Telefon: {deneyim.TelefonNumarasi}, " +
                              $"Sefer No: {deneyim.SeferNumarasi}, Deneyim: {deneyim.DeneyimMetni}";
                checkedListBoxControlDeneyimler.Items.Add(item);
            }
        }
    }
}
