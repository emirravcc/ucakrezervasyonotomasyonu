using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonOtomasyon
{
    class KullanıcıYönetimi
    {

        private static KullanıcıYönetimi _instance;
        public Kullanıcı GirişYapanKullanıcı { get; private set; }

        private KullanıcıYönetimi() { }

        public static KullanıcıYönetimi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KullanıcıYönetimi();
                }
                return _instance;
            }
        }

        public void GirişYapanKullanıcıyıAyarla(Kullanıcı kullanıcı)
        {
            GirişYapanKullanıcı = kullanıcı;
        }


    }
}
