using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonOtomasyon
{
    class ÖdemeYönetimi
    {

        public void ÖdemeEkle(Ödeme ödeme)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = @"INSERT INTO ödemeler (sefer_id, koltuk_no, ödeme_tutarı, müşteri_id) 
                             VALUES (@SeferID, @KoltukNo, @ÖdemeTutarı, @MüşteriID)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SeferID", ödeme.SeferID);
                    command.Parameters.AddWithValue("@KoltukNo", ödeme.KoltukNo);
                    command.Parameters.AddWithValue("@ÖdemeTutarı", ödeme.ÖdemeTutarı);
                    command.Parameters.AddWithValue("@MüşteriID", ödeme.MüşteriID);

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
