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
    partial class MusteriPaneli : Form
    {
        public MusteriPaneli()
        {
            InitializeComponent();
        }

        CBanka bankaAPP;
        String musteriTuru;
        Hesap h;
        BireyselMusteri bireyselMusteri;
        TicariMusteri ticariMusteri;
        HesapOzeti hesapOzeti1;
        HesapOzeti hesapOzeti;
        List<HesapOzeti> a = new List<HesapOzeti>();
        public MusteriPaneli(CBanka bankaAPP, BireyselMusteri bm, String musteri)
        {
            InitializeComponent();
            this.bireyselMusteri = bm;
            musteriTuru = musteri;
            this.bankaAPP = bankaAPP;
        }
        public MusteriPaneli(CBanka bankaAPP, TicariMusteri tm, String musteri)
        {
            InitializeComponent();
            musteriTuru = musteri;
            this.ticariMusteri = tm;
            this.bankaAPP = bankaAPP;
        }

        private void MusteriPaneli_Load(object sender, EventArgs e)
        {
            cbSilinecekHesap.Items.Clear();
            cbParaCekme.Items.Clear();
            cbHavaleYapilcakHesap.Items.Clear();
            cbParaYatirma.Items.Clear();
            cmHesapOzeti.Items.Clear();
            gridHesapListele.DataSource = null;
            gridHesapOzeti.DataSource = null;
            if (musteriTuru == "BireyselMusteri")
            {
                gridHesapListele.DataSource = bireyselMusteri.HesaplariListele();
                foreach (var item in bireyselMusteri.HesaplariListele())
                {
                    cbSilinecekHesap.Items.Add(item.HesapNo);
                    cbParaCekme.Items.Add(item.HesapNo);
                    cbHavaleYapilcakHesap.Items.Add(item.HesapNo);
                    cbParaYatirma.Items.Add(item.HesapNo);
                    cmHesapOzeti.Items.Add(item.HesapNo);
                }
            }
            else
            {
                foreach (var item in ticariMusteri.HesaplariListele())
                {
                    cbSilinecekHesap.Items.Add(item.HesapNo);
                    cbParaCekme.Items.Add(item.HesapNo);
                    cbHavaleYapilcakHesap.Items.Add(item.HesapNo);
                    cbParaYatirma.Items.Add(item.HesapNo);
                    cmHesapOzeti.Items.Add(item.HesapNo);
                }
                gridHesapListele.DataSource = ticariMusteri.HesaplariListele();
            }
        }
        private void btnHesapEkle_Click(object sender, EventArgs e)
        {

            gridHesapListele.DataSource = null;
            h = new Hesap();
            if (musteriTuru == "BireyselMusteri")
            {
                bireyselMusteri.HesapEkle(bireyselMusteri, h);
                cbSilinecekHesap.Items.Add(h.HesapNo);
                cbHavaleYapilcakHesap.Items.Add(h.HesapNo);
                cbParaCekme.Items.Add(h.HesapNo);
                cbParaYatirma.Items.Add(h.HesapNo);
                cmHesapOzeti.Items.Add(h.HesapNo);
                gridHesapListele.DataSource = bireyselMusteri.HesaplariListele();
            }
            else if (musteriTuru == "TicariMusteri")
            {
                ticariMusteri.HesapEkle(ticariMusteri, h);
                cbSilinecekHesap.Items.Add(h.HesapNo);
                cbHavaleYapilcakHesap.Items.Add(h.HesapNo);
                cbParaCekme.Items.Add(h.HesapNo);
                cbParaYatirma.Items.Add(h.HesapNo);
                cmHesapOzeti.Items.Add(h.HesapNo);
                gridHesapListele.DataSource = ticariMusteri.HesaplariListele();
            }
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            if (musteriTuru == "BireyselMusteri")
            {
                int index = cbSilinecekHesap.SelectedIndex;
                Boolean silinsinMi = false;
                long hesapNo = Convert.ToInt64(cbSilinecekHesap.Text);
                silinsinMi = bireyselMusteri.HesapSil(bireyselMusteri, hesapNo);
                if (silinsinMi)
                {
                    cbSilinecekHesap.Items.RemoveAt(index);
                    cbParaCekme.Items.RemoveAt(index);
                    cmHesapOzeti.Items.Add(index);
                    cbHavaleYapilcakHesap.Items.RemoveAt(index);
                    cbParaYatirma.Items.RemoveAt(index);
                    gridHesapListele.DataSource = bireyselMusteri.HesaplariListele();
                }
            }
            if (musteriTuru == "TicariMusteri")
            {
                int index = cbSilinecekHesap.SelectedIndex;
                Boolean silinsinMi = false;
                long hesapNo = Convert.ToInt64(cbSilinecekHesap.Text);
                silinsinMi = ticariMusteri.HesapSil(bireyselMusteri, hesapNo);
                if (silinsinMi)
                {
                    cbSilinecekHesap.Items.RemoveAt(index);
                    cmHesapOzeti.Items.RemoveAt(index);
                    cbParaCekme.Items.RemoveAt(index);
                    cbHavaleYapilcakHesap.Items.RemoveAt(index);
                    cbParaYatirma.Items.RemoveAt(index);
                    gridHesapListele.DataSource = ticariMusteri.HesaplariListele();
                }
            }
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            long secilenHesapNumarasi = Convert.ToInt64(cbParaYatirma.Text);
            Boolean basariliMi = false;
            hesapOzeti = new HesapOzeti();
            if (musteriTuru == "BireyselMusteri")
            {
                foreach (var hesapNo in bireyselMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        if (Convert.ToInt64(txtParaYatirmaMiktar.Text) > 0)
                        {
                            basariliMi = hesapNo.ParaYatir(Convert.ToDecimal(txtParaYatirmaMiktar.Text), hesapOzeti);
                        }
                        else
                            MessageBox.Show("Para Yatirma Miktrarı 0 dan büyük olmalı");
                        if (basariliMi)
                        {
                            MessageBox.Show("Para Yatirma Başarılı ");
                            lbParaYatirmaParaToplam.Text = hesapNo.Bakiye.ToString();
                            gridHesapListele.DataSource = bireyselMusteri.HesaplariListele();
                        }
                    }
                }
            }
            if (musteriTuru == "TicariMusteri")
            {
                foreach (var hesapNo in ticariMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        if (Convert.ToInt64(txtParaYatirmaMiktar.Text) > 0)
                        {
                            basariliMi = hesapNo.ParaYatir(Convert.ToDecimal(txtParaYatirmaMiktar.Text), hesapOzeti);
                        }
                        else
                            MessageBox.Show("Para Yatirma Miktrarı 0 dan büyük olmalı");
                        if (basariliMi)
                        {
                            MessageBox.Show("Para Yatirma Başarılı ");
                            lbParaYatirmaParaToplam.Text = hesapNo.Bakiye.ToString();
                            gridHesapListele.DataSource = ticariMusteri.HesaplariListele();
                        }
                    }
                }
            }
        }
        private void btnParaCekme_Click(object sender, EventArgs e)
        {
            long secilenHesapNumarasi = Convert.ToInt64(cbParaCekme.Text);
            Boolean basariliMi = false;
            hesapOzeti = new HesapOzeti();

            if (musteriTuru == "BireyselMusteri")
            {
                foreach (var hesapNo in bireyselMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        if (Convert.ToInt64(txtParaCekme.Text) > 0)
                        {
                            basariliMi = hesapNo.ParaCekebilen(Convert.ToDecimal(txtParaCekme.Text), hesapOzeti);
                        }
                        else
                            MessageBox.Show("Çekilen Para Miktrarı 0 dan büyük olmalı");
                        if (basariliMi)
                        {
                            MessageBox.Show("Para Çekme Başarılı ");
                            labelKullanılabilirParaCekme.Text = hesapNo.Bakiye.ToString();
                            gridHesapListele.DataSource = bireyselMusteri.HesaplariListele();
                        }
                    }
                }
            }
            if (musteriTuru == "TicariMusteri")
            {
                foreach (var hesapNo in ticariMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        if (Convert.ToInt64(txtParaCekme.Text) > 0)
                        {
                            basariliMi = hesapNo.ParaCekebilen(Convert.ToDecimal(txtParaCekme.Text), hesapOzeti);
                        }
                        else
                            MessageBox.Show("Çekilen Para Miktrarı 0 dan büyük olmalı");
                        if (basariliMi)
                        {
                            MessageBox.Show("Para Çekme Başarılı ");
                            labelKullanılabilirParaCekme.Text = hesapNo.Bakiye.ToString();
                            gridHesapListele.DataSource = ticariMusteri.HesaplariListele();
                        }
                    }
                }
            }
        }
        private void cbParaYatirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            long secilenHesapNumarasi = Convert.ToInt64(cbParaYatirma.Text);
            if (musteriTuru == "BireyselMusteri")
            {
                foreach (var hesapNo in bireyselMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        lbParaYatirmaParaToplam.Text = hesapNo.Bakiye.ToString();
                    }
                }
            }
            if (musteriTuru == "TicariMusteri")
            {
                foreach (var hesapNo in ticariMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        lbParaYatirmaParaToplam.Text = hesapNo.Bakiye.ToString();
                    }
                }
            }
        }
        private void cbParaCekme_SelectedIndexChanged(object sender, EventArgs e)
        {
            long secilenHesapNumarasi = Convert.ToInt64(cbParaCekme.Text);
            if (musteriTuru == "BireyselMusteri")
            {
                foreach (var hesapNo in bireyselMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        labelKullanılabilirParaCekme.Text = hesapNo.Bakiye.ToString();
                    }
                }
            }
            if (musteriTuru == "TicariMusteri")
            {
                foreach (var hesapNo in ticariMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        labelKullanılabilirParaCekme.Text = hesapNo.Bakiye.ToString();
                    }
                }
            }
        }
        private void cbHavaleYapilcakHesap_SelectedIndexChanged(object sender, EventArgs e)
        {
            long secilenHesapNumarasi = Convert.ToInt64(cbHavaleYapilcakHesap.Text);
            if (musteriTuru == "BireyselMusteri")
            {
                foreach (var hesapNo in bireyselMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        labelHavaleKullanabilirBakiye.Text = hesapNo.Bakiye.ToString();
                    }
                }
            }
            if (musteriTuru == "TicariMusteri")
            {
                foreach (var hesapNo in ticariMusteri.Hesaplar)
                {
                    if (hesapNo.HesapNo == secilenHesapNumarasi)
                    {
                        labelHavaleKullanabilirBakiye.Text = hesapNo.Bakiye.ToString();
                    }
                }
            }

        }

        private void btnParaHavale_Click(object sender, EventArgs e)
        {
            Boolean basariliMi = false;
            Boolean hesapVarMi = false;
            hesapOzeti = new HesapOzeti();
            hesapOzeti1 = new HesapOzeti();

            if (musteriTuru == "BireyselMusteri")
            {
                if (Convert.ToInt64(txtParaHavale.Text) > 0)
                {
                    decimal para = Convert.ToDecimal(txtParaHavale.Text);
                    foreach (BireyselMusteri bireysel in bankaAPP.BireyselMusteriListesi)
                    {
                        foreach (Hesap hesap in bireysel.Hesaplar)
                        {
                            if (hesap.HesapNo == Convert.ToInt64(txtHavaleAlinanHesapNo.Text))
                            {
                                hesapVarMi = true;
                                foreach (var item in bireyselMusteri.Hesaplar)
                                {
                                    if (item.HesapNo == Convert.ToInt64(cbHavaleYapilcakHesap.Text))
                                    {
                                        basariliMi = item.Havale(hesap, para, hesapOzeti, hesapOzeti1,musteriTuru);
                                        if (basariliMi)
                                        {
                                            MessageBox.Show(bireysel.Ad + " İsme Para Gönderme İşlemi Başarılı");
                                            gridHesapListele.DataSource = bireyselMusteri.HesaplariListele();
                                            labelHavaleKullanabilirBakiye.Text = item.Bakiye.ToString();
                                        }

                                    }
                                }
                            }
                        }
                    }
                    foreach (TicariMusteri ticari in bankaAPP.TicariMusteriListesi)
                    {
                        foreach (Hesap hesap in ticari.Hesaplar)
                        {
                            if (hesap.HesapNo == Convert.ToInt64(txtHavaleAlinanHesapNo.Text))
                            {
                                hesapVarMi = true;
                                foreach (var item in bireyselMusteri.Hesaplar)
                                {
                                    if (item.HesapNo == Convert.ToInt64(cbHavaleYapilcakHesap.Text))
                                    {
                                        basariliMi = item.Havale(hesap, para, hesapOzeti, hesapOzeti1,musteriTuru);
                                        if (basariliMi)
                                        {
                                            MessageBox.Show(ticari.Ad + " İsme Para Gönderme İşlemi Başarılı");
                                            gridHesapListele.DataSource = bireyselMusteri.HesaplariListele();
                                            labelHavaleKullanabilirBakiye.Text = item.Bakiye.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!hesapVarMi)
                    {
                        MessageBox.Show("Girmiş olduğunuz hesap numarası bulunamadı");
                    }
                }
                else
                    MessageBox.Show("0 dan büyük bir ücret giriniz");

            }
            if (musteriTuru == "TicariMusteri")
            {
                if (Convert.ToInt64(txtParaHavale.Text) > 0)
                {
                    decimal para = Convert.ToDecimal(txtParaHavale.Text);
                    foreach (TicariMusteri ticari in bankaAPP.TicariMusteriListesi)
                    {
                        foreach (Hesap hesap in ticari.Hesaplar)
                        {
                            if (hesap.HesapNo == Convert.ToInt64(txtHavaleAlinanHesapNo.Text))
                            {
                                hesapVarMi = true;
                                foreach (var item in ticariMusteri.Hesaplar)
                                {
                                    if (item.HesapNo == Convert.ToInt64(cbHavaleYapilcakHesap.Text))
                                    {
                                        basariliMi = item.Havale(hesap, para, hesapOzeti, hesapOzeti1,musteriTuru);
                                        if (basariliMi)
                                        {
                                            MessageBox.Show(ticari.Ad + " İsme Para Gönderme İşlemi Başarılı");
                                            gridHesapListele.DataSource = ticariMusteri.HesaplariListele();
                                            labelHavaleKullanabilirBakiye.Text = item.Bakiye.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    foreach (BireyselMusteri bireysel in bankaAPP.BireyselMusteriListesi)
                    {
                        foreach (Hesap hesap in bireysel.Hesaplar)
                        {
                            if (hesap.HesapNo == Convert.ToInt64(txtHavaleAlinanHesapNo.Text))
                            {
                                hesapVarMi = true;
                                foreach (var item in ticariMusteri.Hesaplar)
                                {
                                    if (item.HesapNo == Convert.ToInt64(cbHavaleYapilcakHesap.Text))
                                    {
                                        basariliMi = item.Havale(hesap, para, hesapOzeti, hesapOzeti1,musteriTuru);
                                        if (basariliMi)
                                        {
                                            MessageBox.Show(bireysel.Ad + " İsme Para Gönderme İşlemi Başarılı");
                                            gridHesapListele.DataSource = ticariMusteri.HesaplariListele();
                                            labelHavaleKullanabilirBakiye.Text = item.Bakiye.ToString();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!hesapVarMi)
                    {
                        MessageBox.Show("Girmiş olduğunuz hesap numarası bulunamadı");
                    }
                }
                else
                    MessageBox.Show("0 dan büyük bir ücret giriniz");

            }
        }

        private void cmHesapOzeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            long secilenHesap = Convert.ToInt64(cmHesapOzeti.Text);

            foreach (BireyselMusteri musteri in bankaAPP.BireyselMusteriListesi)
            {
                foreach (Hesap hesap in musteri.Hesaplar)
                {
                    if (hesap.HesapNo == secilenHesap)
                    {

                    }
                }
            }
            foreach (TicariMusteri musteri in bankaAPP.TicariMusteriListesi)
            {
                foreach (Hesap hesap in musteri.Hesaplar)
                {
                    if (hesap.HesapNo == secilenHesap)
                    {

                    }
                }
            }
        }
        
        private void btnHesapOzeti_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangicZamani = Convert.ToDateTime(dtBaslangic.Text);
            DateTime dtBitisZamani = Convert.ToDateTime(dtBitis.Text);
            TimeSpan fark = dtBitisZamani - dtBaslangicZamani;
            a.Clear();
            if (musteriTuru == "BireyselMusteri")
            {
                foreach (BireyselMusteri musteri in bankaAPP.BireyselMusteriListesi)
                {
                    foreach (Hesap hesap in musteri.Hesaplar)
                    {
                        if (hesap.HesapNo == Convert.ToInt64(cmHesapOzeti.Text))
                        {
                            if ((dtBaslangicZamani < dtBitisZamani))
                            {
                                a.AddRange(hesap.HesapOzetGoster().Where(x => x.IslemTarihi >= dtBaslangicZamani && x.IslemTarihi <= dtBitisZamani).ToList());
                            }
                        }
                    }
                    gridHesapOzeti.DataSource = null;
                    gridHesapOzeti.DataSource = a;
                }
            }
            else
            {
                foreach (TicariMusteri musteri in bankaAPP.TicariMusteriListesi)
                {
                    foreach (Hesap hesap in musteri.Hesaplar)
                    {
                        if (hesap.HesapNo == Convert.ToInt64(cmHesapOzeti.Text))
                        {
                            if ((dtBaslangicZamani < dtBitisZamani))
                            {
                                a.AddRange(hesap.HesapOzetGoster().Where(x => x.IslemTarihi >= dtBaslangicZamani && x.IslemTarihi <= dtBitisZamani).ToList());
                            }
                        }
                    }
                    gridHesapOzeti.DataSource = null;
                    gridHesapOzeti.DataSource = a;
                }
            }
        }

        private void txtParaYatirmaMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtParaCekme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtHavaleAlinanHesapNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtParaHavale_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}

