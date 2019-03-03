using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
    public class HesapViewModel
    {
        public string HesabSahibi { get; set; }
        private decimal bakiye;
        private decimal ekBakiye;
        public long HesapNo { get; set; }
        public decimal Bakiye { get { return bakiye; } set { bakiye = value; } }
        public decimal EkHesapBakiye { get { return ekBakiye; }  set { ekBakiye = value; } }

    }
}
