using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
    public abstract class Kisi
    {
        private long tcNo;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TcKimlikNo { get { return tcNo; } set { this.tcNo = value; } }
        public string Adres { get; set; }
        public long Telefon { get; set; }
        public DateTime DogumTarihi { get; set; }

    }
}
