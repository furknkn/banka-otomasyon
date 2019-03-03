using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaProje
{
    class BireyselMusteri : Musteri
    {
        int sayac = 1;
       

        public BireyselMusteri()
        {
            
        }

        public override void HesapEkle(Musteri ha, Hesap h)
        {

            h.HesabSahibi = ha.Ad;
            string hesapNo = Convert.ToString(ha.MusteriNo) + Convert.ToString(sayac);
            h.HesapNo = Convert.ToInt64(hesapNo);
            Hesaplar.Add(h);
            sayac++;
        }
        public override List<HesapViewModel> HesaplariListele()
        {
            hesaplar = new List<HesapViewModel>();

            foreach (var item in Hesaplar)
            {
                HesapViewModel h = new HesapViewModel() { Bakiye = item.Bakiye, HesabSahibi = item.HesabSahibi, HesapNo = item.HesapNo, EkHesapBakiye = item.EkHesapBakiye };
                hesaplar.Add(h);
            }

            return hesaplar;
        }

        public override Boolean HesapSil(Musteri m, long hesapNo)
        {
            Boolean kontrol = false;
            foreach (var hesap in Hesaplar)
            {
                if (hesap.HesapNo == hesapNo)
                {
                    if (hesap.Bakiye == 0)
                    {
                        if (hesap.EkHesapBakiye == 300)
                        {
                            System.Windows.Forms.MessageBox.Show("Müşteri Başarıyla Silindi");
                            Hesaplar.Remove(hesap);
                            kontrol = true;
                            break;
                        }
                        else
                            System.Windows.Forms.MessageBox.Show(hesap.fark + "Borcunuz var hesabınız kapatılamaz");
                    }
                    else
                        System.Windows.Forms.MessageBox.Show(hesap.Bakiye + "Bakiyeniz var hesabınız kapatılamaz");
                }
            }
            return kontrol;
        }
    }
}
