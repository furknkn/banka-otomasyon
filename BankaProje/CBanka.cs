using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
    class CBanka
    {
        public List<Personel> PersonelListesi;
        public List<BireyselMusteri> BireyselMusteriListesi;
        public List<TicariMusteri> TicariMusteriListesi;
        public List<Hesap> HesaplarListesi;
        public List<Rapor> RaporlarListesi;
        Rapor r;

        public CBanka()
        {
            this.RaporlarListesi = new List<Rapor>();
            PersonelListesi = new List<Personel>();
            BireyselMusteriListesi = new List<BireyselMusteri>();
            r = new Rapor();
            TicariMusteriListesi = new List<TicariMusteri>();
            HesaplarListesi = new List<Hesap>();
        }
        public void BireyselMusteriEkle(BireyselMusteri m)
        {
            BireyselMusteriListesi.Add(m);         

        }
        public void TicariMusteriEkle(TicariMusteri m)
        {
            TicariMusteriListesi.Add(m);
        }
        public void PersonelEkle(Personel p)
        {
            PersonelListesi.Add(p);
        }
        public List<Musteri> MusteriListele()
        {
            List<Musteri> musteri = new List<Musteri>();
            foreach(Musteri bireysel in BireyselMusteriListesi)
            {
                musteri.Add(bireysel);
            }
            foreach(Musteri ticari in TicariMusteriListesi)
            {
                musteri.Add(ticari);
            }
            return musteri;
        }


        public List<Rapor> RapolariListele()
        {
            RaporlarListesi = new List<Rapor>();
            r = new Rapor();
            
            foreach (var item in BireyselMusteriListesi)
            {
                foreach (Hesap h in item.Hesaplar)
                {
                    r.HavaleGelirleri += h.ToplamHavale;
                    r.MusteriToplamPara += h.Bakiye;
                }

            }
            foreach (var item in TicariMusteriListesi)
            {
                foreach (Hesap h in item.Hesaplar)
                {
                    r.HavaleGelirleri += h.ToplamHavale;
                    r.MusteriToplamPara += h.Bakiye;
                }

            }
            foreach (var item in PersonelListesi)
            {
                r.PersonelGiderleri += item.Maas;
            }
            RaporlarListesi.Add(r);
            

            return RaporlarListesi;
        }
    }


}
