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
using MySqlConnector;

namespace UcakRezervasyonOtomasyon
{
    public partial class ucKullanıcıYönetimi : DevExpress.XtraEditors.XtraUserControl
    {

        private static ucKullanıcıYönetimi _instance;

        public static ucKullanıcıYönetimi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucKullanıcıYönetimi();
                return _instance;
            }
        }


        public ucKullanıcıYönetimi()
        {
            InitializeComponent();
        }

        private void ucKullanıcıYönetimi_Load(object sender, EventArgs e)
        {
            checkedListBoxControlKullanıcılar.Items.Clear(); // Mevcut öğeleri temizle
            List<Kullanıcı> kullanıcılar = Veritabanı.Instance.TümKullanıcılarıGetir();

            foreach (var kullanıcı in kullanıcılar)
            {
                checkedListBoxControlKullanıcılar.Items.Add($"{kullanıcı.Id} - {kullanıcı.KullanıcıAdı} {kullanıcı.Tc} {kullanıcı.Isim} {kullanıcı.SoyAd} {kullanıcı.Telefon}");
            }
        }

        private void simpleButtonKullanıcıSil_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in checkedListBoxControlKullanıcılar.CheckedItems)
            {
                // ID'yi ayır ve int'e çevir
                string selected = selectedItem.ToString();
                int kullanıcıID = int.Parse(selected.Split('-')[0].Trim());

                Veritabanı.Instance.KullanıcıSil(kullanıcıID); // Kullanıcıyı sil
            }

            // Güncellenmiş listeyi yeniden yükle
            ucKullanıcıYönetimi_Load(sender, e);

            MessageBox.Show("Seçilen kullanıcılar başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
