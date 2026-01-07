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
    public partial class ucUçuşlarım : DevExpress.XtraEditors.XtraUserControl
    {

        private static ucUçuşlarım _instance;

        public static ucUçuşlarım Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUçuşlarım();
                return _instance;
            }
        }

        public ucUçuşlarım()
        {
            InitializeComponent();
            KullaniciBiletBilgileriniYükle(KullanıcıYönetimi.Instance.GirişYapanKullanıcı.Id);
        }



        private void KullaniciBiletBilgileriniYükle(int musteriID)
        {
            checkedListBoxControlUçuşlarım.Items.Clear(); // Önceki öğeleri temizle

            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = @"
            SELECT 
                o.koltuk_no, 
                o.ödeme_tutarı, 
                o.ödeme_tarihi, 
                s.nereden, 
                s.nereye, 
                s.tarihGidiş, 
                s.tarihDönüş 
            FROM 
                ödemeler o
            JOIN 
                seferler s ON o.sefer_id = s.id
            WHERE 
                o.müşteri_id = @MusteriID";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MusteriID", musteriID);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string koltukNo = reader["koltuk_no"].ToString();
                            decimal odemeTutari = Convert.ToDecimal(reader["ödeme_tutarı"]);
                            DateTime odemeTarihi = Convert.ToDateTime(reader["ödeme_tarihi"]);
                            string nereden = reader["nereden"].ToString();
                            string nereye = reader["nereye"].ToString();
                            DateTime tarihGidis = Convert.ToDateTime(reader["tarihGidiş"]);
                            DateTime? tarihDonus = reader["tarihDönüş"] != DBNull.Value
                                ? Convert.ToDateTime(reader["tarihDönüş"])
                                : (DateTime?)null;

                            string biletBilgisi = $"Koltuk: {koltukNo}, Tutar: {odemeTutari:C}, Tarih: {odemeTarihi:yyyy-MM-dd HH:mm}" +
                                                  $", Uçuş: {nereden} -> {nereye}, Gidiş: {tarihGidis:yyyy-MM-dd HH:mm}" +
                                                  $"{(tarihDonus.HasValue ? $", Dönüş: {tarihDonus:yyyy-MM-dd HH:mm}" : "")}";

                            checkedListBoxControlUçuşlarım.Items.Add(biletBilgisi);
                        }
                    }
                }
            }
        }



    }
}
