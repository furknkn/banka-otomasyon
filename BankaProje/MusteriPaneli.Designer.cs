namespace BankaProje
{
    partial class MusteriPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriPaneli));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnHesapEkle = new DevExpress.XtraEditors.SimpleButton();
            this.gridHesapListele = new System.Windows.Forms.DataGridView();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cbSilinecekHesap = new System.Windows.Forms.ComboBox();
            this.btnHesapSil = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.labelKullanılabilirParaCekme = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnParaCekme = new DevExpress.XtraEditors.SimpleButton();
            this.txtParaCekme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbParaCekme = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.cbHavaleYapilcakHesap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHavaleKullanabilirBakiye = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHavaleAlinanHesapNo = new System.Windows.Forms.TextBox();
            this.btnParaHavale = new DevExpress.XtraEditors.SimpleButton();
            this.txtParaHavale = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabNavigationPage6 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.gridHesapOzeti = new System.Windows.Forms.DataGridView();
            this.btnHesapOzeti = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cmHesapOzeti = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.lbParaYatirmaParaToplam = new System.Windows.Forms.Label();
            this.lb112 = new System.Windows.Forms.Label();
            this.btnParaYatir = new DevExpress.XtraEditors.SimpleButton();
            this.txtParaYatirmaMiktar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbParaYatirma = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapListele)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.tabNavigationPage5.SuspendLayout();
            this.tabNavigationPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapOzeti)).BeginInit();
            this.tabNavigationPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Controls.Add(this.tabNavigationPage6);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage4,
            this.tabNavigationPage3,
            this.tabNavigationPage5,
            this.tabNavigationPage6});
            this.tabPane1.RegularSize = new System.Drawing.Size(796, 261);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(796, 261);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Hesap Ekleme";
            this.tabNavigationPage1.Controls.Add(this.btnHesapEkle);
            this.tabNavigationPage1.Controls.Add(this.gridHesapListele);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Size = new System.Drawing.Size(778, 197);
            // 
            // btnHesapEkle
            // 
            this.btnHesapEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnHesapEkle.Location = new System.Drawing.Point(3, 3);
            this.btnHesapEkle.Name = "btnHesapEkle";
            this.btnHesapEkle.Size = new System.Drawing.Size(159, 190);
            this.btnHesapEkle.TabIndex = 1;
            this.btnHesapEkle.Text = "Hesap Aç";
            this.btnHesapEkle.Click += new System.EventHandler(this.btnHesapEkle_Click);
            // 
            // gridHesapListele
            // 
            this.gridHesapListele.AllowUserToAddRows = false;
            this.gridHesapListele.AllowUserToDeleteRows = false;
            this.gridHesapListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHesapListele.Location = new System.Drawing.Point(161, 3);
            this.gridHesapListele.Name = "gridHesapListele";
            this.gridHesapListele.ReadOnly = true;
            this.gridHesapListele.Size = new System.Drawing.Size(450, 190);
            this.gridHesapListele.TabIndex = 0;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Hesap Silme";
            this.tabNavigationPage2.Controls.Add(this.cbSilinecekHesap);
            this.tabNavigationPage2.Controls.Add(this.btnHesapSil);
            this.tabNavigationPage2.Controls.Add(this.label1);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Size = new System.Drawing.Size(778, 197);
            // 
            // cbSilinecekHesap
            // 
            this.cbSilinecekHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSilinecekHesap.FormattingEnabled = true;
            this.cbSilinecekHesap.Location = new System.Drawing.Point(164, 60);
            this.cbSilinecekHesap.Name = "cbSilinecekHesap";
            this.cbSilinecekHesap.Size = new System.Drawing.Size(121, 21);
            this.cbSilinecekHesap.TabIndex = 4;
            // 
            // btnHesapSil
            // 
            this.btnHesapSil.Location = new System.Drawing.Point(164, 106);
            this.btnHesapSil.Name = "btnHesapSil";
            this.btnHesapSil.Size = new System.Drawing.Size(75, 23);
            this.btnHesapSil.TabIndex = 2;
            this.btnHesapSil.Text = "Sil";
            this.btnHesapSil.Click += new System.EventHandler(this.btnHesapSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silinecek Hesabınızı Seçiniz";
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Para Çekme";
            this.tabNavigationPage3.Controls.Add(this.labelKullanılabilirParaCekme);
            this.tabNavigationPage3.Controls.Add(this.label10);
            this.tabNavigationPage3.Controls.Add(this.btnParaCekme);
            this.tabNavigationPage3.Controls.Add(this.txtParaCekme);
            this.tabNavigationPage3.Controls.Add(this.label5);
            this.tabNavigationPage3.Controls.Add(this.cbParaCekme);
            this.tabNavigationPage3.Controls.Add(this.label2);
            this.tabNavigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage3.ImageOptions.Image")));
            this.tabNavigationPage3.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage3.Size = new System.Drawing.Size(778, 197);
            // 
            // labelKullanılabilirParaCekme
            // 
            this.labelKullanılabilirParaCekme.AutoSize = true;
            this.labelKullanılabilirParaCekme.Location = new System.Drawing.Point(126, 68);
            this.labelKullanılabilirParaCekme.Name = "labelKullanılabilirParaCekme";
            this.labelKullanılabilirParaCekme.Size = new System.Drawing.Size(13, 13);
            this.labelKullanılabilirParaCekme.TabIndex = 17;
            this.labelKullanılabilirParaCekme.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Kullanabilir Bakiye";
            // 
            // btnParaCekme
            // 
            this.btnParaCekme.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnParaCekme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParaCekme.ImageOptions.Image")));
            this.btnParaCekme.Location = new System.Drawing.Point(126, 136);
            this.btnParaCekme.Name = "btnParaCekme";
            this.btnParaCekme.Size = new System.Drawing.Size(111, 35);
            this.btnParaCekme.TabIndex = 15;
            this.btnParaCekme.Text = "Çek";
            this.btnParaCekme.Click += new System.EventHandler(this.btnParaCekme_Click);
            // 
            // txtParaCekme
            // 
            this.txtParaCekme.Location = new System.Drawing.Point(129, 98);
            this.txtParaCekme.Name = "txtParaCekme";
            this.txtParaCekme.Size = new System.Drawing.Size(100, 20);
            this.txtParaCekme.TabIndex = 14;
            this.txtParaCekme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParaCekme_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Miktar Giriniz";
            // 
            // cbParaCekme
            // 
            this.cbParaCekme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParaCekme.FormattingEnabled = true;
            this.cbParaCekme.Location = new System.Drawing.Point(126, 27);
            this.cbParaCekme.Name = "cbParaCekme";
            this.cbParaCekme.Size = new System.Drawing.Size(121, 21);
            this.cbParaCekme.TabIndex = 7;
            this.cbParaCekme.SelectedIndexChanged += new System.EventHandler(this.cbParaCekme_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hesap Seçiniz";
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.Caption = "Havale";
            this.tabNavigationPage5.Controls.Add(this.cbHavaleYapilcakHesap);
            this.tabNavigationPage5.Controls.Add(this.label3);
            this.tabNavigationPage5.Controls.Add(this.labelHavaleKullanabilirBakiye);
            this.tabNavigationPage5.Controls.Add(this.label12);
            this.tabNavigationPage5.Controls.Add(this.txtHavaleAlinanHesapNo);
            this.tabNavigationPage5.Controls.Add(this.btnParaHavale);
            this.tabNavigationPage5.Controls.Add(this.txtParaHavale);
            this.tabNavigationPage5.Controls.Add(this.label6);
            this.tabNavigationPage5.Controls.Add(this.label7);
            this.tabNavigationPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage5.ImageOptions.Image")));
            this.tabNavigationPage5.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage5.Size = new System.Drawing.Size(778, 197);
            // 
            // cbHavaleYapilcakHesap
            // 
            this.cbHavaleYapilcakHesap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHavaleYapilcakHesap.FormattingEnabled = true;
            this.cbHavaleYapilcakHesap.Location = new System.Drawing.Point(142, 20);
            this.cbHavaleYapilcakHesap.Name = "cbHavaleYapilcakHesap";
            this.cbHavaleYapilcakHesap.Size = new System.Drawing.Size(121, 21);
            this.cbHavaleYapilcakHesap.TabIndex = 23;
            this.cbHavaleYapilcakHesap.SelectedIndexChanged += new System.EventHandler(this.cbHavaleYapilcakHesap_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Hesap Numarasını\r\n Giriniz";
            // 
            // labelHavaleKullanabilirBakiye
            // 
            this.labelHavaleKullanabilirBakiye.AutoSize = true;
            this.labelHavaleKullanabilirBakiye.Location = new System.Drawing.Point(142, 96);
            this.labelHavaleKullanabilirBakiye.Name = "labelHavaleKullanabilirBakiye";
            this.labelHavaleKullanabilirBakiye.Size = new System.Drawing.Size(13, 13);
            this.labelHavaleKullanabilirBakiye.TabIndex = 21;
            this.labelHavaleKullanabilirBakiye.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Kullanabilir Bakiye";
            // 
            // txtHavaleAlinanHesapNo
            // 
            this.txtHavaleAlinanHesapNo.Location = new System.Drawing.Point(142, 62);
            this.txtHavaleAlinanHesapNo.MaxLength = 12;
            this.txtHavaleAlinanHesapNo.Name = "txtHavaleAlinanHesapNo";
            this.txtHavaleAlinanHesapNo.Size = new System.Drawing.Size(100, 20);
            this.txtHavaleAlinanHesapNo.TabIndex = 18;
            this.txtHavaleAlinanHesapNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHavaleAlinanHesapNo_KeyPress);
            // 
            // btnParaHavale
            // 
            this.btnParaHavale.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnParaHavale.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParaHavale.ImageOptions.Image")));
            this.btnParaHavale.Location = new System.Drawing.Point(142, 146);
            this.btnParaHavale.Name = "btnParaHavale";
            this.btnParaHavale.Size = new System.Drawing.Size(111, 35);
            this.btnParaHavale.TabIndex = 17;
            this.btnParaHavale.Text = "Yatır";
            this.btnParaHavale.Click += new System.EventHandler(this.btnParaHavale_Click);
            // 
            // txtParaHavale
            // 
            this.txtParaHavale.Location = new System.Drawing.Point(142, 120);
            this.txtParaHavale.Name = "txtParaHavale";
            this.txtParaHavale.Size = new System.Drawing.Size(100, 20);
            this.txtParaHavale.TabIndex = 16;
            this.txtParaHavale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParaHavale_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Miktar Giriniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Alıcı Hesap\r\nNumarasını Giriniz";
            // 
            // tabNavigationPage6
            // 
            this.tabNavigationPage6.Caption = "Hesap Özeti";
            this.tabNavigationPage6.Controls.Add(this.label11);
            this.tabNavigationPage6.Controls.Add(this.label4);
            this.tabNavigationPage6.Controls.Add(this.dtBaslangic);
            this.tabNavigationPage6.Controls.Add(this.dtBitis);
            this.tabNavigationPage6.Controls.Add(this.gridHesapOzeti);
            this.tabNavigationPage6.Controls.Add(this.btnHesapOzeti);
            this.tabNavigationPage6.Controls.Add(this.label8);
            this.tabNavigationPage6.Controls.Add(this.cmHesapOzeti);
            this.tabNavigationPage6.Controls.Add(this.label9);
            this.tabNavigationPage6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage6.ImageOptions.Image")));
            this.tabNavigationPage6.Name = "tabNavigationPage6";
            this.tabNavigationPage6.Size = new System.Drawing.Size(778, 197);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Bitiş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Başlangıç";
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Location = new System.Drawing.Point(59, 43);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(200, 20);
            this.dtBaslangic.TabIndex = 21;
            this.dtBaslangic.Value = new System.DateTime(2017, 12, 28, 0, 0, 0, 0);
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(59, 84);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(200, 20);
            this.dtBitis.TabIndex = 20;
            // 
            // gridHesapOzeti
            // 
            this.gridHesapOzeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHesapOzeti.Location = new System.Drawing.Point(287, 3);
            this.gridHesapOzeti.Name = "gridHesapOzeti";
            this.gridHesapOzeti.Size = new System.Drawing.Size(488, 181);
            this.gridHesapOzeti.TabIndex = 19;
            // 
            // btnHesapOzeti
            // 
            this.btnHesapOzeti.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnHesapOzeti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapOzeti.ImageOptions.Image")));
            this.btnHesapOzeti.Location = new System.Drawing.Point(84, 151);
            this.btnHesapOzeti.Name = "btnHesapOzeti";
            this.btnHesapOzeti.Size = new System.Drawing.Size(111, 35);
            this.btnHesapOzeti.TabIndex = 17;
            this.btnHesapOzeti.Text = "Yatır";
            this.btnHesapOzeti.Click += new System.EventHandler(this.btnHesapOzeti_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tarih Aralığı Giriniz";
            // 
            // cmHesapOzeti
            // 
            this.cmHesapOzeti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmHesapOzeti.FormattingEnabled = true;
            this.cmHesapOzeti.Location = new System.Drawing.Point(85, 124);
            this.cmHesapOzeti.Name = "cmHesapOzeti";
            this.cmHesapOzeti.Size = new System.Drawing.Size(121, 21);
            this.cmHesapOzeti.TabIndex = 14;
            this.cmHesapOzeti.SelectedIndexChanged += new System.EventHandler(this.cmHesapOzeti_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hesap Seçiniz";
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "ParaYatırma";
            this.tabNavigationPage4.Controls.Add(this.lbParaYatirmaParaToplam);
            this.tabNavigationPage4.Controls.Add(this.lb112);
            this.tabNavigationPage4.Controls.Add(this.btnParaYatir);
            this.tabNavigationPage4.Controls.Add(this.txtParaYatirmaMiktar);
            this.tabNavigationPage4.Controls.Add(this.label13);
            this.tabNavigationPage4.Controls.Add(this.cbParaYatirma);
            this.tabNavigationPage4.Controls.Add(this.label14);
            this.tabNavigationPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage4.ImageOptions.Image")));
            this.tabNavigationPage4.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage4.Size = new System.Drawing.Size(778, 197);
            // 
            // lbParaYatirmaParaToplam
            // 
            this.lbParaYatirmaParaToplam.AutoSize = true;
            this.lbParaYatirmaParaToplam.Location = new System.Drawing.Point(135, 65);
            this.lbParaYatirmaParaToplam.Name = "lbParaYatirmaParaToplam";
            this.lbParaYatirmaParaToplam.Size = new System.Drawing.Size(13, 13);
            this.lbParaYatirmaParaToplam.TabIndex = 24;
            this.lbParaYatirmaParaToplam.Text = "0";
            // 
            // lb112
            // 
            this.lb112.AutoSize = true;
            this.lb112.Location = new System.Drawing.Point(43, 65);
            this.lb112.Name = "lb112";
            this.lb112.Size = new System.Drawing.Size(92, 13);
            this.lb112.TabIndex = 23;
            this.lb112.Text = "Kullanabilir Bakiye";
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnParaYatir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnParaYatir.ImageOptions.Image")));
            this.btnParaYatir.Location = new System.Drawing.Point(135, 133);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(111, 35);
            this.btnParaYatir.TabIndex = 22;
            this.btnParaYatir.Text = "Yatır";
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // txtParaYatirmaMiktar
            // 
            this.txtParaYatirmaMiktar.Location = new System.Drawing.Point(138, 95);
            this.txtParaYatirmaMiktar.Name = "txtParaYatirmaMiktar";
            this.txtParaYatirmaMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtParaYatirmaMiktar.TabIndex = 21;
            this.txtParaYatirmaMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParaYatirmaMiktar_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Miktar Giriniz";
            // 
            // cbParaYatirma
            // 
            this.cbParaYatirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParaYatirma.FormattingEnabled = true;
            this.cbParaYatirma.Location = new System.Drawing.Point(135, 24);
            this.cbParaYatirma.Name = "cbParaYatirma";
            this.cbParaYatirma.Size = new System.Drawing.Size(121, 21);
            this.cbParaYatirma.TabIndex = 19;
            this.cbParaYatirma.SelectedIndexChanged += new System.EventHandler(this.cbParaYatirma_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Hesap Seçiniz";
            // 
            // MusteriPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 261);
            this.Controls.Add(this.tabPane1);
            this.Name = "MusteriPaneli";
            this.Text = "MusteriPaneli";
            this.Load += new System.EventHandler(this.MusteriPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapListele)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            this.tabNavigationPage5.ResumeLayout(false);
            this.tabNavigationPage5.PerformLayout();
            this.tabNavigationPage6.ResumeLayout(false);
            this.tabNavigationPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHesapOzeti)).EndInit();
            this.tabNavigationPage4.ResumeLayout(false);
            this.tabNavigationPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraEditors.SimpleButton btnHesapEkle;
        private System.Windows.Forms.DataGridView gridHesapListele;
        private DevExpress.XtraEditors.SimpleButton btnHesapSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage6;
        private System.Windows.Forms.ComboBox cbSilinecekHesap;
        private DevExpress.XtraEditors.SimpleButton btnParaCekme;
        private System.Windows.Forms.TextBox txtParaCekme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbParaCekme;
        private System.Windows.Forms.TextBox txtHavaleAlinanHesapNo;
        private DevExpress.XtraEditors.SimpleButton btnParaHavale;
        private System.Windows.Forms.TextBox txtParaHavale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridHesapOzeti;
        private DevExpress.XtraEditors.SimpleButton btnHesapOzeti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmHesapOzeti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelKullanılabilirParaCekme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHavaleKullanabilirBakiye;
        private System.Windows.Forms.ComboBox cbHavaleYapilcakHesap;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private System.Windows.Forms.Label lbParaYatirmaParaToplam;
        private System.Windows.Forms.Label lb112;
        private DevExpress.XtraEditors.SimpleButton btnParaYatir;
        private System.Windows.Forms.TextBox txtParaYatirmaMiktar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbParaYatirma;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
    }
}