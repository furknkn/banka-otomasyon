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
    public partial class ProgramGiris : Form
    {
        public ProgramGiris()
        {
            InitializeComponent();
        }

        CBanka bankaAPP = new CBanka();
        BireyselMusteri bm;
        TicariMusteri tc;
        
        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {

            if (txtMusteriID.Text.Length==11 && txtMusteriID.Text!=null)
            {
                long MusteriNo = Convert.ToInt64(txtMusteriID.Text);
                foreach (BireyselMusteri musteri in bankaAPP.BireyselMusteriListesi)
                {
                    if (musteri.TcKimlikNo.ToString() == txtMusteriID.Text)
                    {
                        MessageBox.Show("Başarılı ");
                        if (musteri.MusteriTuru == "BireyselMusteri") {
                            string musteriTuru = musteri.MusteriTuru;
                            MusteriPaneli musteriPanel = new MusteriPaneli(bankaAPP, musteri, musteriTuru);
                            musteriPanel.Show();
                        }
                    }
                }
                foreach (TicariMusteri musteri in bankaAPP.TicariMusteriListesi)
                {
                    if (musteri.TcKimlikNo.ToString() == txtMusteriID.Text.ToString())
                    {
                        MessageBox.Show("Başarılı ");
                        if (musteri.MusteriTuru == "TicariMusteri")
                        {
                            string musteriTuru = musteri.MusteriTuru;
                            MusteriPaneli musteriPanel = new MusteriPaneli(bankaAPP, musteri, musteriTuru);
                            musteriPanel.Show();
                        }
                    }
                }

            }
            else if (txtMusteriID.Text=="" )
            {
                MessageBox.Show("Müşteri numarası boş");
            } 
            else if(txtMusteriID.Text.Length<12 || txtMusteriID.Text != null)
            {
                MessageBox.Show("Müşteri numarası bulunamadı");
            }
            else
                MessageBox.Show("Müşteri numarası hatalı");
        }

        private void btnBankaGiris_Click(object sender, EventArgs e)
        {
            if(txtBankID.Text != null && txtBankPass.Text != "" &&txtBankID.Text!=""&&txtBankPass.Text!=null)
            {
                string ID = txtBankID.Text;
                string Sifre = txtBankPass.Text;
                if (ID == "admin" && Sifre == "admin")
                {
                    Banka bankaPaneli = new Banka(bankaAPP);
                    bankaPaneli.Show();
                }
                else
                    MessageBox.Show("Giriş başarısız.(ID admin Şifre admin)");
            }
            else
                MessageBox.Show("Boş geçilemez..");
        }

        private void ProgramGiris_Load(object sender, EventArgs e)
        {
        }

        private void txtMusteriID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
