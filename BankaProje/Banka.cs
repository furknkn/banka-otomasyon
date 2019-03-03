using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaProje
{
    partial class Banka : Form
    {
        public Banka()
        {
            InitializeComponent();
        }
        CBanka bankaAPP;
        BireyselMusteri bm;
        TicariMusteri tc;
        Personel per;
        public Banka(CBanka bankaAPP)
        {
            InitializeComponent();
            this.bankaAPP = bankaAPP;
        }
        private void Banka_Load(object sender, EventArgs e)
        {
            gridMusteriListele.DataSource = null;
            gridMusteriListele.DataSource = bankaAPP.MusteriListele();
            gridPersonelListele.DataSource = null;
            gridPersonelListele.DataSource = bankaAPP.PersonelListesi;
            gridBankaRaporu.DataSource = null;
            gridBankaRaporu.DataSource = bankaAPP.RapolariListele();
            
           
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            gridMusteriListele.DataSource = null;
            MusteriEkle();
            gridMusteriListele.DataSource = bankaAPP.MusteriListele();
          
            
        }
        void MusteriEkle()
        {
            Boolean MusteriVarmi = true;
            if (txtMusAd.Text == "" || txtMusAdres.Text == "" ||
                txtMusSoyAd.Text == "" || txtMusTcNo.Text == ""
                || txtMusTcNo == null || txtMusTelefon.Text == "" || txtMusTelefon == null
                )
                MessageBox.Show("* Alanlar Boş Bırakılamaz");
            else
            {
                if (txtMusTcNo.Text.Length < 11)
                {
                    MessageBox.Show("Tc Kimlik Numarası 11 Haneden Küçük Olamaz");
                }
                else
                {
                    foreach (Musteri musteri in bankaAPP.MusteriListele())
                    {

                        if (musteri.MusteriNo.ToString() == txtMusTcNo.Text)
                        {
                            MusteriVarmi = false;
                        }
                    }
                        if (cbMusHesapTuru.Text == "BireyselMusteri" && MusteriVarmi )
                    {
                        bm = new BireyselMusteri();

                        bm.Ad = txtMusAd.Text;
                        bm.MusteriTuru = cbMusHesapTuru.Text;
                        bm.Soyad = txtMusSoyAd.Text;
                        bm.Adres = txtMusAdres.Text;
                        bm.TcKimlikNo = Convert.ToInt64(txtMusTcNo.Text);
                        bm.MusteriNo = Convert.ToInt64(txtMusTcNo.Text);
                        bm.MusteriKayitTarihi = dtMusteriKayitTarihi.Value;
                        bm.Telefon = Convert.ToInt64(txtMusTelefon.Text);
                        bm.DogumTarihi = dtMusDogumTarihi.Value;
                        bankaAPP.BireyselMusteriEkle(bm);
                        MessageBox.Show("Müşteri Ekleme İşlemi Başarılı.");
                     
                    }
                        
                    if (cbMusHesapTuru.Text == "TicariMusteri" && MusteriVarmi)
                    {
                        tc = new TicariMusteri();

                        tc.Ad = txtMusAd.Text;
                        tc.MusteriTuru = cbMusHesapTuru.Text;
                        tc.Soyad = txtMusSoyAd.Text;
                        tc.Adres = txtMusAdres.Text;
                        tc.MusteriNo = Convert.ToInt64(txtMusTcNo.Text);
                        tc.MusteriKayitTarihi = dtMusteriKayitTarihi.Value;
                        tc.TcKimlikNo = Convert.ToInt64(txtMusTcNo.Text);
                        tc.Telefon = Convert.ToInt64(txtMusTelefon.Text);
                        tc.DogumTarihi = dtMusDogumTarihi.Value;
                        bankaAPP.TicariMusteriEkle(tc);
                        MessageBox.Show("Müşteri Ekleme İşlemi Başarılı.");
                       
                    }
                    else if (!MusteriVarmi)
                    {
                        MessageBox.Show("Böyle bir TcKimlik numaralı müşteri bulunuyor");
                    }
                }
            }
        } 

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
          
            gridBankaRaporu.DataSource = null;
            PersonelEkle();
            gridMusteriListele.DataSource = bankaAPP.PersonelListesi;
        }
        void PersonelEkle()
        {

            Boolean PersonelVarmi = false;
            if (txtPerAd.Text == "" || txtPerAdres.Text == "" ||
                txtPerSoyAd.Text == "" || txtPerTcNo.Text == ""
                || txtPerTcNo == null || txtPerTelefon.Text == "" || txtPerTelefon == null
                )
                MessageBox.Show("* Alanlar Boş Bırakılamaz");
            else
            {
                if (txtPerTcNo.Text.Length < 11)
                {
                    MessageBox.Show("Tc Kimlik Numarası 11 Haneden Küçük Olamaz");
                }
                else
                {
                    
                    foreach (Personel personel in bankaAPP.PersonelListesi)
                    {

                        if (personel.TcKimlikNo.ToString() == txtPerTcNo.Text)
                        {
                            PersonelVarmi = true;
                        }
                    }
                    if (!PersonelVarmi){
                        per = new Personel();
                        per.Ad = txtPerAd.Text;
                        per.Soyad = txtPerSoyAd.Text;
                        per.Adres = txtPerAdres.Text;
                        per.TcKimlikNo = Convert.ToInt64(txtPerTcNo.Text);
                        per.Telefon = Convert.ToInt64(txtPerTelefon.Text);
                        per.BaslamaTarihi = dtPerIseBaslamaTarihi.Value;
                        per.PersonelTuru = cbPersonelTuru.Text;
                        per.PersonelNo = Convert.ToInt64(txtPerTcNo.Text);
                        per.DogumTarihi = dtPerDogumTarihi.Value;
                        bankaAPP.PersonelEkle(per);
                        MessageBox.Show("Personel Ekleme İşlemi Başarılı.");
                    }
                    else if (PersonelVarmi)
                    {
                        MessageBox.Show("Böyle bir TcNumaralı personel bulunuyor");
                    }
                }
            }
        }

        private void txtMusTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMusTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMusAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);


        }

        private void txtMusSoyAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);


        }

        private void txtPerAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);


        }

        private void txtPerSoyAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);


        }

        private void txtPerTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPerTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
