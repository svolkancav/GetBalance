namespace GetBalance.UI
{
    partial class FormUyeGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeGirisi));
            panel1 = new Panel();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnOturumAc = new Button();
            lnklblSifreUnuttum = new LinkLabel();
            lnklblHesapOlustur = new LinkLabel();
            label2 = new Label();
            panel2 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 179, 35);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 150);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(309, 60);
            label1.Name = "label1";
            label1.Size = new Size(161, 35);
            label1.TabIndex = 0;
            label1.Text = "OTURUM AÇ";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(224, 470);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(310, 31);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(224, 532);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(310, 31);
            txtSifre.TabIndex = 2;
            // 
            // btnOturumAc
            // 
            btnOturumAc.BackColor = Color.FromArgb(47, 47, 47);
            btnOturumAc.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnOturumAc.ForeColor = SystemColors.ButtonHighlight;
            btnOturumAc.Location = new Point(224, 605);
            btnOturumAc.Name = "btnOturumAc";
            btnOturumAc.Size = new Size(309, 43);
            btnOturumAc.TabIndex = 3;
            btnOturumAc.Text = "OTURUM AÇ";
            btnOturumAc.UseVisualStyleBackColor = false;
            // 
            // lnklblSifreUnuttum
            // 
            lnklblSifreUnuttum.AutoSize = true;
            lnklblSifreUnuttum.BackColor = Color.Transparent;
            lnklblSifreUnuttum.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lnklblSifreUnuttum.LinkColor = Color.FromArgb(15, 179, 35);
            lnklblSifreUnuttum.Location = new Point(277, 662);
            lnklblSifreUnuttum.Name = "lnklblSifreUnuttum";
            lnklblSifreUnuttum.Size = new Size(225, 28);
            lnklblSifreUnuttum.TabIndex = 4;
            lnklblSifreUnuttum.TabStop = true;
            lnklblSifreUnuttum.Text = "Şifrenizi mi Unuttunuz?";
            lnklblSifreUnuttum.LinkClicked += lnklblSifreUnuttum_LinkClicked;
            // 
            // lnklblHesapOlustur
            // 
            lnklblHesapOlustur.AutoSize = true;
            lnklblHesapOlustur.BackColor = Color.Transparent;
            lnklblHesapOlustur.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lnklblHesapOlustur.LinkColor = Color.FromArgb(15, 179, 35);
            lnklblHesapOlustur.Location = new Point(391, 772);
            lnklblHesapOlustur.Name = "lnklblHesapOlustur";
            lnklblHesapOlustur.Size = new Size(142, 28);
            lnklblHesapOlustur.TabIndex = 5;
            lnklblHesapOlustur.TabStop = true;
            lnklblHesapOlustur.Text = "Hesap Oluştur";
            lnklblHesapOlustur.LinkClicked += lnklblHesapOlustur_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(209, 772);
            label2.Name = "label2";
            label2.Size = new Size(178, 28);
            label2.TabIndex = 6;
            label2.Text = "Üye Değil misiniz?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 47, 47);
            panel2.Controls.Add(nightControlBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(773, 60);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(574, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(277, 220);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 222);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormUyeGirisi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(773, 847);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(lnklblHesapOlustur);
            Controls.Add(lnklblSifreUnuttum);
            Controls.Add(btnOturumAc);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUyeGirisi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUyeGirisi";
            Load += FormUyeGirisi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnOturumAc;
        private LinkLabel lnklblSifreUnuttum;
        private LinkLabel lnklblHesapOlustur;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}
