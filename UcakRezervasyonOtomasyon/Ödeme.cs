using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonOtomasyon
{
    public class Ödeme
    {
        public int SeferID { get; set; }
        public string KoltukNo { get; set; }
        public decimal ÖdemeTutarı { get; set; }
        public int MüşteriID { get; set; }
    }
}
