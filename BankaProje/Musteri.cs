using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
    abstract class Musteri:Kisi
    {
        private long musteriNo;
        public string MusteriTuru { get; set; }
        public DateTime MusteriKayitTarihi { get; set; }
        public long MusteriNo { get { return musteriNo; } set { musteriNo = value; } }
        Hesap hesap;
        public List<Hesap> Hesaplar;
        protected List<HesapViewModel> hesaplar;

        public Musteri() 
        {
            this.Hesaplar = new List<Hesap>();
            this.musteriNo = this.TcKimlikNo;
            hesap = new Hesap();
        }
        public Musteri(Hesap h)
        {
            this.musteriNo = this.TcKimlikNo;
            hesap = new Hesap();

        }
        public abstract void HesapEkle(Musteri m,Hesap h);
        public abstract Boolean HesapSil(Musteri m, long hesapNo);
        public abstract List<HesapViewModel> HesaplariListele();

       
    }
}
