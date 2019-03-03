using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
     class Personel :Kisi
    {
        private long personelNo;
        public long PersonelNo { get { return personelNo; } set { personelNo = value; } }
        public string PersonelTuru { get; set; }
        public decimal Maas { get; private set; }
        public DateTime BaslamaTarihi { get; set; }
        public Personel()
        {
            this.personelNo = this.TcKimlikNo;
            this.Maas = 2000;
        }
        public Personel(int TcNo)
        {
            this.Maas = 2000;
            this.personelNo = TcNo;
        }
    }
}
