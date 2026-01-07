using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonOtomasyon
{
    class Veritabanı
    {

        // Singleton için private static instance
        private static Veritabanı _instance;

        // MySqlConnection nesnesi
        private MySqlConnection _connection;

        // Bağlantı cümlesi (Connection String)
        private readonly string _connectionString = "Server=localhost;Database=ucakotomasyondb;User ID=root;Password=;";

        // Constructor'ı private yaparak dışardan erişimi engelle
        private Veritabanı() { }

        // Singleton instance erişim metodu
        public static Veritabanı Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Veritabanı();
                }
                return _instance;
            }
        }

        // Bağlantı nesnesini dönen ve bağlantı durumunu kontrol eden metot
        public MySqlConnection GetConnection()
        {
            if (_connection == null || _connection.State == System.Data.ConnectionState.Closed)
            {
                _connection = new MySqlConnection(_connectionString);
                _connection.Open();
            }

            return _connection;
        }

        // Bağlantıyı kapatma metodu
        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        // Bağlantı durumunu kontrol eden metot
        public bool IsConnected()
        {
            if (_connection == null)
            {
                return false;
            }

            return _connection.State == System.Data.ConnectionState.Open;
        }
        public void KullanıcıEkle(Kullanıcı kullanıcı)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = @"INSERT INTO kullanıcılar 
                        (kullanıcıAdı, epostaAdresi, parola, tc, isim, soyAd, cinsiyet, telefon, doğumTarihi, admin)
                        VALUES (@kullanıcıAdı, @epostaAdresi, @parola, @tc, @isim, @soyAd, @cinsiyet, @telefon, @doğumTarihi, @admin)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@kullanıcıAdı", kullanıcı.KullanıcıAdı);
                cmd.Parameters.AddWithValue("@epostaAdresi", kullanıcı.EpostaAdresi);
                cmd.Parameters.AddWithValue("@parola", kullanıcı.Parola);
                cmd.Parameters.AddWithValue("@tc", kullanıcı.Tc);
                cmd.Parameters.AddWithValue("@isim", kullanıcı.Isim);
                cmd.Parameters.AddWithValue("@soyAd", kullanıcı.SoyAd);
                cmd.Parameters.AddWithValue("@cinsiyet", kullanıcı.Cinsiyet);
                cmd.Parameters.AddWithValue("@telefon", kullanıcı.Telefon);
                cmd.Parameters.AddWithValue("@doğumTarihi", kullanıcı.DoğumTarihi);
                cmd.Parameters.AddWithValue("@admin", kullanıcı.AdminStatus); // adminStatus bilgisi de ekleniyor

                cmd.ExecuteNonQuery();
            }
        }

        public List<Kullanıcı> TümKullanıcılarıGetir()
        {
            List<Kullanıcı> kullanıcılar = new List<Kullanıcı>();

            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT id, kullanıcıAdı, epostaAdresi, parola, tc, isim, soyAd, cinsiyet, telefon, doğumTarihi, admin FROM kullanıcılar";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kullanıcılar.Add(new Kullanıcı(
                                Id: Convert.ToInt32(reader["id"]),  // Id burada alınıyor
                                kullanıcıAdı: reader["kullanıcıAdı"].ToString(),
                                epostaAdresi: reader["epostaAdresi"].ToString(),
                                parola: reader["parola"].ToString(),
                                TC: reader["tc"].ToString(),
                                isim: reader["isim"].ToString(),
                                soyisim: reader["soyAd"].ToString(),
                                cinsiyet: reader["cinsiyet"].ToString(),
                                telefon: reader["telefon"].ToString(),
                                doğumTarihi: Convert.ToDateTime(reader["doğumTarihi"]),
                                adminStatus: reader["admin"].ToString()
                            ));
                        }
                    }
                }
            }

            return kullanıcılar;
        }



        public void KullanıcıSil(int kullanıcıID)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "DELETE FROM kullanıcılar WHERE id = @id";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", kullanıcıID);
                    cmd.ExecuteNonQuery();
                }
            }
        }






        public Kullanıcı KullanıcıBilgileriniGetir(string kullanıcıAdı)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = @"SELECT id, kullanıcıAdı, epostaAdresi, parola, tc, isim, soyAd, cinsiyet, telefon, doğumTarihi, admin  
                         FROM kullanıcılar 
                         WHERE kullanıcıAdı = @kullanıcıAdı";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@kullanıcıAdı", kullanıcıAdı);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Kullanıcıyı doğru constructor ile döndürüyoruz
                        return new Kullanıcı(
                            Id: Convert.ToInt32(reader["id"]),
                            kullanıcıAdı: reader["kullanıcıAdı"].ToString(),
                            epostaAdresi: reader["epostaAdresi"].ToString(),
                            parola: reader["parola"].ToString(),
                            TC: reader["tc"].ToString(),
                            isim: reader["isim"].ToString(),
                            soyisim: reader["soyAd"].ToString(),
                            cinsiyet: reader["cinsiyet"].ToString(),
                            telefon: reader["telefon"].ToString(),
                            doğumTarihi: Convert.ToDateTime(reader["doğumTarihi"]),
                            adminStatus: reader["admin"].ToString()
                        );
                    }
                }
            }

            // Eğer kullanıcı bulunamazsa null döner.
            return null;
        }


        public bool KullanıcıAdminMi(string kullanıcıAdı)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = @"SELECT admin 
                         FROM kullanıcılar 
                         WHERE kullanıcıAdı = @kullanıcıAdı";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@kullanıcıAdı", kullanıcıAdı);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Admin sütunu "true" olarak text içeriyorsa true döner, değilse false
                        return reader["admin"].ToString().ToLower() == "true";
                    }
                }
            }

            // Kullanıcı bulunamazsa false döner
            return false;
        }




        public void KullanıcıGüncelle(Kullanıcı kullanıcı)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = @"UPDATE kullanıcılar 
                         SET epostaAdresi = @epostaAdresi,
                             tc = @Tc,
                             parola = @parola, 
                             isim = @isim, 
                             soyAd = @soyAd, 
                             cinsiyet = @cinsiyet, 
                             telefon = @telefon, 
                             doğumTarihi = @doğumTarihi
                         WHERE kullanıcıAdı = @kullanıcıAdı";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Tc", kullanıcı.Tc);

                cmd.Parameters.AddWithValue("@kullanıcıAdı", kullanıcı.KullanıcıAdı);
                cmd.Parameters.AddWithValue("@epostaAdresi", kullanıcı.EpostaAdresi);
                cmd.Parameters.AddWithValue("@parola", kullanıcı.Parola);
                cmd.Parameters.AddWithValue("@isim", kullanıcı.Isim);
                cmd.Parameters.AddWithValue("@soyAd", kullanıcı.SoyAd);
                cmd.Parameters.AddWithValue("@cinsiyet", kullanıcı.Cinsiyet);
                cmd.Parameters.AddWithValue("@telefon", kullanıcı.Telefon);
                cmd.Parameters.AddWithValue("@doğumTarihi", kullanıcı.DoğumTarihi);

                cmd.ExecuteNonQuery();
            }
        }


        public bool KullanıcıGiris(string kullanıcıAdı, string parola)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM kullanıcılar WHERE kullanıcıAdı = @kullanıcıAdı AND parola = @parola";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@kullanıcıAdı", kullanıcıAdı);
                cmd.Parameters.AddWithValue("@parola", parola);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }





        public void SeferOlustur(string nereden, string nereye, string seferTipi, DateTime tarihGidis, DateTime? tarihDonus)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                // 1. Sefer ekle
                var command = new MySqlCommand("INSERT INTO seferler (nereden, nereye, seferTipi, tarihGidiş, tarihDönüş) VALUES (@Nereden, @Nereye, @SeferTipi, @TarihGidis, @TarihDonus); SELECT LAST_INSERT_ID();", connection);
                command.Parameters.AddWithValue("@Nereden", nereden);
                command.Parameters.AddWithValue("@Nereye", nereye);
                command.Parameters.AddWithValue("@SeferTipi", seferTipi);
                command.Parameters.AddWithValue("@TarihGidis", tarihGidis); // Tarih ve saat bilgisi burada tam olarak gönderiliyor.
                command.Parameters.AddWithValue("@TarihDonus", tarihDonus.HasValue ? tarihDonus.Value : (object)DBNull.Value);

                long seferID = Convert.ToInt64(command.ExecuteScalar()); // Eklenen SeferID'yi al

                // 2. Koltukları ekle
                for (char row = 'A'; row <= 'F'; row++)
                {
                    for (int col = 1; col <= 8; col++)
                    {
                        string koltukNo = $"{row}{col}";

                        command.CommandText = "INSERT INTO koltuklar (sefer_id, koltuk_no, durum, tip) VALUES (@SeferID, @KoltukNo, @Durum, @Tip)";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@SeferID", seferID);
                        command.Parameters.AddWithValue("@KoltukNo", koltukNo);
                        command.Parameters.AddWithValue("@Durum", false);

                        if (seferTipi == "Gidiş-Dönüş")
                        {
                            command.Parameters.AddWithValue("@Tip", "Gidiş");
                            command.ExecuteNonQuery();

                            command.Parameters["@Tip"].Value = "Dönüş";
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Tip", "Gidiş");
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        public void koltukGüncelle(int seferID, string selectedSeat)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "UPDATE koltuklar SET durum = TRUE WHERE sefer_id = @SeferID AND koltuk_no = @KoltukNo";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SeferID", seferID);
                    command.Parameters.AddWithValue("@KoltukNo", selectedSeat);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void DeneyimEkle(string adSoyad, string epostaAdresi, string telefonNumarasi, int seferNumarasi, string deneyim)
        {
            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = @"INSERT INTO deneyimler (ad_soyad, eposta_adresi, telefon_numarasi, sefer_numarasi, deneyim) 
                         VALUES (@adSoyad, @epostaAdresi, @telefonNumarasi, @seferNumarasi, @deneyim)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@adSoyad", adSoyad);
                cmd.Parameters.AddWithValue("@epostaAdresi", epostaAdresi);
                cmd.Parameters.AddWithValue("@telefonNumarasi", telefonNumarasi);
                cmd.Parameters.AddWithValue("@seferNumarasi", seferNumarasi);
                cmd.Parameters.AddWithValue("@deneyim", deneyim);

                cmd.ExecuteNonQuery();
            }
        }


        public List<Deneyim> DeneyimleriGetir()
        {
            List<Deneyim> deneyimler = new List<Deneyim>();

            using (var connection = Veritabanı.Instance.GetConnection())
            {
                string query = "SELECT id, ad_soyad, eposta_adresi, telefon_numarasi, sefer_numarasi, deneyim FROM deneyimler";

                using (var cmd = new MySqlCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            deneyimler.Add(new Deneyim
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                AdSoyad = reader["ad_soyad"].ToString(),
                                EpostaAdresi = reader["eposta_adresi"].ToString(),
                                TelefonNumarasi = reader["telefon_numarasi"].ToString(),
                                SeferNumarasi = Convert.ToInt32(reader["sefer_numarasi"]),
                                DeneyimMetni = reader["deneyim"].ToString()
                            });
                        }
                    }
                }
            }

            return deneyimler;
        }













    }
}
