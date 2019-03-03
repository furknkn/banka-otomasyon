namespace BankaProje
{
    partial class ProgramGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramGiris));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.btnMusteriGiris = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnBankaGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtBankPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(262, 261);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(262, 261);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Müşteri Giriş";
            this.tabNavigationPage1.Controls.Add(this.label4);
            this.tabNavigationPage1.Controls.Add(this.txtMusteriID);
            this.tabNavigationPage1.Controls.Add(this.btnMusteriGiris);
            this.tabNavigationPage1.Controls.Add(this.label1);
            this.tabNavigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.ImageOptions.Image")));
            this.tabNavigationPage1.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage1.Size = new System.Drawing.Size(244, 197);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(104, 62);
            this.txtMusteriID.MaxLength = 11;
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(100, 20);
            this.txtMusteriID.TabIndex = 2;
            this.txtMusteriID.TextChanged += new System.EventHandler(this.txtMusteriID_TextChanged);
            this.txtMusteriID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriID_KeyPress);
            // 
            // btnMusteriGiris
            // 
            this.btnMusteriGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnMusteriGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriGiris.ImageOptions.Image")));
            this.btnMusteriGiris.Location = new System.Drawing.Point(129, 97);
            this.btnMusteriGiris.Name = "btnMusteriGiris";
            this.btnMusteriGiris.Size = new System.Drawing.Size(36, 52);
            this.btnMusteriGiris.TabIndex = 1;
            this.btnMusteriGiris.Click += new System.EventHandler(this.btnMusteriGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Banka Giriş";
            this.tabNavigationPage2.Controls.Add(this.btnBankaGiris);
            this.tabNavigationPage2.Controls.Add(this.txtBankPass);
            this.tabNavigationPage2.Controls.Add(this.label3);
            this.tabNavigationPage2.Controls.Add(this.txtBankID);
            this.tabNavigationPage2.Controls.Add(this.label2);
            this.tabNavigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage2.ImageOptions.Image")));
            this.tabNavigationPage2.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabNavigationPage2.Size = new System.Drawing.Size(244, 197);
            // 
            // btnBankaGiris
            // 
            this.btnBankaGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnBankaGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBankaGiris.ImageOptions.Image")));
            this.btnBankaGiris.Location = new System.Drawing.Point(127, 126);
            this.btnBankaGiris.Name = "btnBankaGiris";
            this.btnBankaGiris.Size = new System.Drawing.Size(44, 46);
            this.btnBankaGiris.TabIndex = 4;
            this.btnBankaGiris.Click += new System.EventHandler(this.btnBankaGiris_Click);
            // 
            // txtBankPass
            // 
            this.txtBankPass.Location = new System.Drawing.Point(106, 91);
            this.txtBankPass.Name = "txtBankPass";
            this.txtBankPass.Size = new System.Drawing.Size(100, 20);
            this.txtBankPass.TabIndex = 3;
            this.txtBankPass.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre";
            // 
            // txtBankID
            // 
            this.txtBankID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBankID.Location = new System.Drawing.Point(106, 37);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.Size = new System.Drawing.Size(100, 20);
            this.txtBankID.TabIndex = 1;
            this.txtBankID.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Müşteri numarası TC kimlik numaranızdır !";
            // 
            // ProgramGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 261);
            this.Controls.Add(this.tabPane1);
            this.Name = "ProgramGiris";
            this.Text = "ProgramGiriş";
            this.Load += new System.EventHandler(this.ProgramGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.TextBox txtMusteriID;
        private DevExpress.XtraEditors.SimpleButton btnMusteriGiris;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnBankaGiris;
        private System.Windows.Forms.TextBox txtBankPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

