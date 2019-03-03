using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
    public class HesapOzeti
    {
        public DateTime IslemTarihi { get; set; }
        public long HesapNo { get; set; }
        public string IslemYapan { get; set; }
        public decimal Tutar { get; set; }
        public string IslemTipi { get; set; }
        public string Aciklama { get; set; }

    }

}
