using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonOtomasyon
{
    class Kullanıcı
    {

        private static Kullanıcı _instance;

        public int Id { get; set; }
        public string KullanıcıAdı { get; set; }
        public string EpostaAdresi { get; set; }
        public string Parola { get; set; }
        public string Tc { get; set; }
        public string Isim { get; set; }
        public string SoyAd { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public DateTime DoğumTarihi { get; set; }
        
        public string AdminStatus { get; set; }





        public Kullanıcı(string kullanıcıAdı, string epostaAdresi, string parola, string TC, string isim, string soyisim, string cinsiyet, string telefon, DateTime doğumTarihi, string adminStatus)
        {

            this.KullanıcıAdı = kullanıcıAdı;
            this.EpostaAdresi = epostaAdresi;
            this.Parola = parola;
            this.Tc = TC;
            this.Isim = isim;
            this.SoyAd = soyisim;
            this.Cinsiyet = cinsiyet;
            this.Telefon = telefon;
            this.DoğumTarihi = doğumTarihi;
            this.AdminStatus = adminStatus;

        }


        public Kullanıcı(int Id, string kullanıcıAdı, string epostaAdresi, string parola, string TC, string isim, string soyisim, string cinsiyet, string telefon, DateTime doğumTarihi, string adminStatus)
        {
            this.Id = Id;

            this.KullanıcıAdı = kullanıcıAdı;
            this.EpostaAdresi = epostaAdresi;
            this.Parola = parola;
            this.Tc = TC;
            this.Isim = isim;
            this.SoyAd = soyisim;
            this.Cinsiyet = cinsiyet;
            this.Telefon = telefon;
            this.DoğumTarihi = doğumTarihi;
            this.AdminStatus = adminStatus;

        }



    }
}
