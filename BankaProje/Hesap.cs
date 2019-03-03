using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
    class Hesap:IParaYatirabilen, IParaCekebilen,IHavaleYapabilen
    {
        public decimal fark = 0;
        public string HesabSahibi { get; set; }
        public decimal ToplamHavale { get; set; }
        private decimal bakiye;
        private decimal ekBakiye;
        public long HesapNo { get; set; }
        public decimal Bakiye { get { return bakiye; } set { bakiye = value; } }
        public decimal EkHesapBakiye { get { return ekBakiye; } private set { } }
        public DateTime GunlukPara { get; set; }
        public decimal GunlukParaLimit = 750;
        List<HesapOzeti> HesapOzet;
        public Hesap()
        {
            this.ekBakiye = 300M;
            GunlukParaLimit = 750;
            HesapOzet = new List<HesapOzeti>();
        }
        public Hesap(Musteri m)
        {
            this.HesabSahibi = m.Ad;
        }
        public Hesap(HesapOzeti h)
        {
            
        }
            
        public List<HesapOzeti> HesapOzetGoster()
        {
            return HesapOzet;
        }
        public Boolean ParaYatir(decimal para,HesapOzeti h)
        {
            Boolean islem = false;
            Boolean tamamMi = false;
            if (ekBakiye <= 300)
            {
                decimal fark;
                ekBakiye += para;
                if (ekBakiye > 300)
                {
                    fark = ekBakiye - 300M;
                    ekBakiye -= fark;
                    bakiye += fark;
                }
                tamamMi = true; }
                if (!tamamMi)
                {
                    bakiye += para;
                }
                h.Aciklama = "Para Yatırma";
                h.HesapNo = HesapNo;
                h.IslemTipi = "Para Yatırma";
                h.IslemYapan = HesabSahibi;
                h.Tutar = para;
                h.IslemTarihi = DateTime.Today;
                HesapOzet.Add(h);
                islem = true;
                return islem;
        }      
        public Boolean ParaCekebilen(decimal para,HesapOzeti h)
        {
            //HesapOzeti topplamCekilen = (HesapOzet.Where(x => x.IslemTarihi == DateTime.Today).GroupBy(x => x.HesapNo) as HesapOzeti);
            Boolean sonuc = false;
           
            if (GunlukParaLimit > para)
            {
                if (para <= 750)
                {
                    if (para > bakiye)
                    {
                        if (para > bakiye + ekBakiye)
                        {
                            System.Windows.Forms.MessageBox.Show("Yetersiz Bakiye");
                        }
                        else
                        {
                            fark = bakiye - para;
                            ekBakiye = ekBakiye + fark;
                           
                            bakiye = 0;
                            h.Aciklama = "Para Çekme";
                            h.HesapNo = HesapNo;
                            h.IslemTipi = "Para Çekme";
                            h.IslemYapan = HesabSahibi;
                            h.Tutar = para;
                            h.IslemTarihi = DateTime.Today;
                            HesapOzet.Add(h);
                            sonuc = true;
                            GunlukParaLimit = GunlukParaLimit - para;
                        }
                    }
                    else if ((bakiye == para || bakiye > para) && !sonuc)
                    {
                        h.Aciklama = "Para Çekme";
                        h.HesapNo = HesapNo;
                        h.IslemTipi = "Para Çekme";
                        h.IslemYapan = HesabSahibi;
                        h.Tutar = para;
                        h.IslemTarihi = DateTime.Today;
                        HesapOzet.Add(h);
                        bakiye -= para;
                        GunlukParaLimit = GunlukParaLimit - para;
                        sonuc = true;
                    }
                }
                else
                    System.Windows.Forms.MessageBox.Show("Günlük para çekme limitiniz 750 TL");
            }
            else
                System.Windows.Forms.MessageBox.Show("Günlük para çekme limitiniz 750 TL");
            return sonuc;
        }
        public Boolean Havale(Hesap h, decimal para,HesapOzeti ha,HesapOzeti h1,string musteriTuru)
        {
            decimal fark;
            Boolean basariliMi = false;
            decimal havaleUcreti;
            Boolean tamamMi = false;
            if(musteriTuru == "BireyselMusteri") {
                if (bakiye >= para)
                {
                    bakiye -= para;
                    havaleUcreti = para * 2 / 100;
                    ToplamHavale += havaleUcreti;
                    para = para - havaleUcreti;
                   
                    
                    if (h.ekBakiye < 301)
                    {
                        h.ekBakiye += para;
                        if (h.ekBakiye > 300)
                        {
                            fark = h.ekBakiye - 300M;
                            h.ekBakiye -= fark;
                            h.bakiye += fark;
                            System.Windows.Forms.MessageBox.Show(havaleUcreti+" TL Havale Ucreti Kesilmiştir");

                        }
                        tamamMi = true;
                    }
                    if (!tamamMi)
                    {
                        h.bakiye += para;
                        bakiye -= para;
                    }
                    h1.Aciklama = "Para Havale";
                    h1.HesapNo = HesapNo;
                    h1.IslemTipi = "Para Havale";
                    h1.IslemYapan = HesabSahibi;
                    h1.Tutar = para;
                    h1.IslemTarihi = DateTime.Today;

                    ha.Aciklama = "GonderenKisi=" + HesabSahibi;
                    ha.HesapNo = h.HesapNo;
                    ha.IslemTipi = "Gelen Havale";
                    ha.IslemYapan = "Banka";
                    ha.Tutar = para;
                    ha.IslemTarihi = DateTime.Today;

                    h.HesapOzet.Add(ha);
                    HesapOzet.Add(h1);
                    basariliMi = true;
                }
                else
                    System.Windows.Forms.MessageBox.Show("Ek hesap sadece para çekmede devreye girer YETERSİZ BAKİYE ! ");
            }

            if (musteriTuru == "TicariMusteri")
            {
                if (bakiye >= para)
                {
                    bakiye -= para;
                    if (h.ekBakiye < 301)
                    {
                        h.ekBakiye += para;
                        if (h.ekBakiye > 300)
                        {
                            fark = h.ekBakiye - 300M;
                            h.ekBakiye -= fark;
                            h.bakiye += fark;
                           
                        }

                        tamamMi = true;
                    }
                    if (!tamamMi)
                    {
                        h.bakiye += para;
                        bakiye -= para;
                    }
                    h1.Aciklama = "Para Havale";
                    h1.HesapNo = HesapNo;
                    h1.IslemTipi = "Para Havale";
                    h1.IslemYapan = HesabSahibi;
                    h1.Tutar = para;
                    h1.IslemTarihi = DateTime.Today;

                    ha.Aciklama = "GonderenKisi=" + HesabSahibi;
                    ha.HesapNo = h.HesapNo;
                    ha.IslemTipi = "Gelen Havale";
                    ha.IslemYapan = "Banka";
                    ha.Tutar = para;
                    ha.IslemTarihi = DateTime.Today;

                    h.HesapOzet.Add(ha);
                    HesapOzet.Add(h1);
                    basariliMi = true;
                }
                else
                    System.Windows.Forms.MessageBox.Show("Ek hesap sadece para çekme de devreye girer YETERSİZ BAKİYE !");
            }
            return basariliMi;

        }
    }
}
