namespace GetBalance.UI
{
    partial class FormHomePage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHome = new PictureBox();
            menuContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            gunlukControl1 = new GunlukControl();
            btnAnaSayfa = new Button();
            panel5 = new Panel();
            profilControl1 = new ProfilControl();
            btnRapor = new Button();
            panel3 = new Panel();
            btnBen = new Button();
            panel4 = new Panel();
            btnGunluk = new Button();
            panel6 = new Panel();
            btnCikis = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            anaSayfaControl1 = new AnaSayfaControl();
            profilControl2 = new ProfilControl();
            anaSayfaControl2 = new AnaSayfaControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            menuContainer.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 47, 47);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(943, 47);
            panel1.TabIndex = 0;
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
            nightControlBox1.Location = new Point(804, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 16);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 2;
            label1.Text = "AnaSayfa";
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(33, 27);
            btnHome.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(47, 47, 47);
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel5);
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel4);
            menuContainer.Controls.Add(panel6);
            menuContainer.Dock = DockStyle.Left;
            menuContainer.Location = new Point(0, 47);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(149, 440);
            menuContainer.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 47, 47);
            panel2.Controls.Add(gunlukControl1);
            panel2.Controls.Add(btnAnaSayfa);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 86);
            panel2.TabIndex = 2;
            // 
            // gunlukControl1
            // 
            gunlukControl1.Location = new Point(145, -3);
            gunlukControl1.Name = "gunlukControl1";
            gunlukControl1.Size = new Size(795, 443);
            gunlukControl1.TabIndex = 1;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackColor = Color.FromArgb(15, 179, 35);
            btnAnaSayfa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnaSayfa.ForeColor = Color.White;
            btnAnaSayfa.Image = (Image)resources.GetObject("btnAnaSayfa.Image");
            btnAnaSayfa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnaSayfa.Location = new Point(0, 17);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(139, 49);
            btnAnaSayfa.TabIndex = 0;
            btnAnaSayfa.Text = "            Ana Sayfa";
            btnAnaSayfa.TextAlign = ContentAlignment.MiddleLeft;
            btnAnaSayfa.UseVisualStyleBackColor = false;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(47, 47, 47);
            panel5.Controls.Add(profilControl1);
            panel5.Controls.Add(btnRapor);
            panel5.Location = new Point(3, 95);
            panel5.Name = "panel5";
            panel5.Size = new Size(146, 86);
            panel5.TabIndex = 5;
            // 
            // profilControl1
            // 
            profilControl1.Location = new Point(145, -95);
            profilControl1.Name = "profilControl1";
            profilControl1.Size = new Size(792, 440);
            profilControl1.TabIndex = 1;
            // 
            // btnRapor
            // 
            btnRapor.BackColor = Color.FromArgb(15, 179, 35);
            btnRapor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRapor.ForeColor = Color.White;
            btnRapor.Image = (Image)resources.GetObject("btnRapor.Image");
            btnRapor.ImageAlign = ContentAlignment.MiddleLeft;
            btnRapor.Location = new Point(0, 17);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(139, 49);
            btnRapor.TabIndex = 0;
            btnRapor.Text = "            Raporlar";
            btnRapor.TextAlign = ContentAlignment.MiddleLeft;
            btnRapor.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(47, 47, 47);
            panel3.Controls.Add(btnBen);
            panel3.Location = new Point(3, 187);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 86);
            panel3.TabIndex = 3;
            // 
            // btnBen
            // 
            btnBen.BackColor = Color.FromArgb(15, 179, 35);
            btnBen.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBen.ForeColor = Color.White;
            btnBen.Image = (Image)resources.GetObject("btnBen.Image");
            btnBen.ImageAlign = ContentAlignment.MiddleLeft;
            btnBen.Location = new Point(0, 17);
            btnBen.Name = "btnBen";
            btnBen.Size = new Size(139, 49);
            btnBen.TabIndex = 0;
            btnBen.Text = "            Profil";
            btnBen.TextAlign = ContentAlignment.MiddleLeft;
            btnBen.UseVisualStyleBackColor = false;
            btnBen.Click += btnBen_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(47, 47, 47);
            panel4.Controls.Add(btnGunluk);
            panel4.Location = new Point(3, 279);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 86);
            panel4.TabIndex = 4;
            // 
            // btnGunluk
            // 
            btnGunluk.BackColor = Color.FromArgb(15, 179, 35);
            btnGunluk.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGunluk.ForeColor = Color.White;
            btnGunluk.Image = (Image)resources.GetObject("btnGunluk.Image");
            btnGunluk.ImageAlign = ContentAlignment.MiddleLeft;
            btnGunluk.Location = new Point(0, 17);
            btnGunluk.Name = "btnGunluk";
            btnGunluk.Size = new Size(139, 49);
            btnGunluk.TabIndex = 0;
            btnGunluk.Text = "            Günlük";
            btnGunluk.TextAlign = ContentAlignment.MiddleLeft;
            btnGunluk.UseVisualStyleBackColor = false;
            btnGunluk.Click += btnGunluk_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(47, 47, 47);
            panel6.Controls.Add(btnCikis);
            panel6.Location = new Point(3, 371);
            panel6.Name = "panel6";
            panel6.Size = new Size(146, 86);
            panel6.TabIndex = 4;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(15, 179, 35);
            btnCikis.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.Image = (Image)resources.GetObject("btnCikis.Image");
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.Location = new Point(0, 17);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(139, 49);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "            Çıkış";
            btnCikis.TextAlign = ContentAlignment.MiddleLeft;
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // anaSayfaControl1
            // 
            anaSayfaControl1.Location = new Point(151, 53);
            anaSayfaControl1.Name = "anaSayfaControl1";
            anaSayfaControl1.Size = new Size(792, 434);
            anaSayfaControl1.TabIndex = 3;
            // 
            // profilControl2
            // 
            profilControl2.Location = new Point(151, 53);
            profilControl2.Name = "profilControl2";
            profilControl2.Size = new Size(792, 437);
            profilControl2.TabIndex = 4;
            // 
            // anaSayfaControl2
            // 
            anaSayfaControl2.Location = new Point(148, 47);
            anaSayfaControl2.Name = "anaSayfaControl2";
            anaSayfaControl2.Size = new Size(795, 443);
            anaSayfaControl2.TabIndex = 3;
            // 
            // FormHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 487);
            Controls.Add(anaSayfaControl2);
            Controls.Add(profilControl2);
            Controls.Add(anaSayfaControl1);
            Controls.Add(menuContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "FormHomePage";
            Text = " ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            menuContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHome;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel menuContainer;
        private Panel panel2;
        private Button btnAnaSayfa;
        private Panel panel3;
        private Button btnBen;
        private Panel panel4;
        private Button btnGunluk;
        private Panel panel5;
        private Button btnRapor;
        private Panel panel6;
        private Button btnCikis;
        private System.Windows.Forms.Timer menuTransition;
        private ProfilControl profilControl1;
        private AnaSayfaControl anaSayfaControl1;
        private ProfilControl profilControl2;
        private AnaSayfaControl anaSayfaControl2;
        private GunlukControl gunlukControl1;
    }
}