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
    public partial class ucSeheyatBilgilendirmesi : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucSeheyatBilgilendirmesi _instance;

        public static ucSeheyatBilgilendirmesi Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucSeheyatBilgilendirmesi();
                return _instance;
            }
        }



        public ucSeheyatBilgilendirmesi()
        {
            InitializeComponent();
        }
    }
}
