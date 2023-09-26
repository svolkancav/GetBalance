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
            panel1 = new Panel();
            label2 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            btnHome = new PictureBox();
            menuContainer = new FlowLayoutPanel();
            panel7 = new Panel();
            panel8 = new Panel();
            btnAnaSayfa = new Button();
            panel2 = new Panel();
            btnProfil = new Button();
            panel9 = new Panel();
            btnGunluk = new Button();
            panel10 = new Panel();
            btnRaporlar = new Button();
            panel11 = new Panel();
            btnAyarlar = new Button();
            panel12 = new Panel();
            btnCikis = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            pnlAnaPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            menuContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 53, 53);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 35);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(583, 6);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 3;
            label2.Text = "GET BALANCE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nightControlBox1
            // 
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.Dock = DockStyle.Right;
            nightControlBox1.EnableCloseColor = Color.White;
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.White;
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.White;
            nightControlBox1.Location = new Point(1141, 0);
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
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 2;
            label1.Text = "MENU";
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Image = Properties.Resources.menu_4_32;
            btnHome.Location = new Point(9, 20);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(30, 30);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(2, 53, 53);
            menuContainer.Controls.Add(panel7);
            menuContainer.Controls.Add(panel8);
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel9);
            menuContainer.Controls.Add(panel10);
            menuContainer.Controls.Add(panel11);
            menuContainer.Controls.Add(panel12);
            menuContainer.Dock = DockStyle.Left;
            menuContainer.Location = new Point(0, 35);
            menuContainer.MaximumSize = new Size(180, 685);
            menuContainer.MinimumSize = new Size(51, 685);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(180, 685);
            menuContainer.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(btnHome);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(177, 71);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnAnaSayfa);
            panel8.Location = new Point(3, 80);
            panel8.Name = "panel8";
            panel8.Size = new Size(173, 40);
            panel8.TabIndex = 1;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackColor = Color.FromArgb(2, 53, 53);
            btnAnaSayfa.FlatAppearance.BorderSize = 0;
            btnAnaSayfa.FlatStyle = FlatStyle.Flat;
            btnAnaSayfa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnaSayfa.ForeColor = Color.White;
            btnAnaSayfa.Image = Properties.Resources.home_7_32;
            btnAnaSayfa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnaSayfa.Location = new Point(-13, -9);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Padding = new Padding(15, 0, 0, 0);
            btnAnaSayfa.Size = new Size(199, 58);
            btnAnaSayfa.TabIndex = 0;
            btnAnaSayfa.Text = "            Ana Sayfa";
            btnAnaSayfa.TextAlign = ContentAlignment.MiddleLeft;
            btnAnaSayfa.UseVisualStyleBackColor = false;
            btnAnaSayfa.Click += btnAnaSayfa_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProfil);
            panel2.Location = new Point(3, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 40);
            panel2.TabIndex = 1;
            // 
            // btnProfil
            // 
            btnProfil.BackColor = Color.FromArgb(2, 53, 53);
            btnProfil.FlatAppearance.BorderSize = 0;
            btnProfil.FlatStyle = FlatStyle.Flat;
            btnProfil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfil.ForeColor = Color.White;
            btnProfil.Image = Properties.Resources.user_32;
            btnProfil.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfil.Location = new Point(-13, -9);
            btnProfil.Name = "btnProfil";
            btnProfil.Padding = new Padding(15, 0, 0, 0);
            btnProfil.Size = new Size(199, 58);
            btnProfil.TabIndex = 0;
            btnProfil.Text = "            Profil";
            btnProfil.TextAlign = ContentAlignment.MiddleLeft;
            btnProfil.UseVisualStyleBackColor = false;
            btnProfil.Click += btnProfil_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnGunluk);
            panel9.Location = new Point(3, 172);
            panel9.Name = "panel9";
            panel9.Size = new Size(173, 40);
            panel9.TabIndex = 1;
            // 
            // btnGunluk
            // 
            btnGunluk.BackColor = Color.FromArgb(2, 53, 53);
            btnGunluk.FlatAppearance.BorderSize = 0;
            btnGunluk.FlatStyle = FlatStyle.Flat;
            btnGunluk.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGunluk.ForeColor = Color.White;
            btnGunluk.Image = Properties.Resources.today_32;
            btnGunluk.ImageAlign = ContentAlignment.MiddleLeft;
            btnGunluk.Location = new Point(-13, -9);
            btnGunluk.Name = "btnGunluk";
            btnGunluk.Padding = new Padding(15, 0, 0, 0);
            btnGunluk.Size = new Size(199, 58);
            btnGunluk.TabIndex = 0;
            btnGunluk.Text = "            Günlük";
            btnGunluk.TextAlign = ContentAlignment.MiddleLeft;
            btnGunluk.UseVisualStyleBackColor = false;
            btnGunluk.Click += btnGunluk_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnRaporlar);
            panel10.Location = new Point(3, 218);
            panel10.Name = "panel10";
            panel10.Size = new Size(173, 40);
            panel10.TabIndex = 1;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.FromArgb(2, 53, 53);
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRaporlar.ForeColor = Color.White;
            btnRaporlar.Image = Properties.Resources.report_3_32;
            btnRaporlar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRaporlar.Location = new Point(-13, -9);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Padding = new Padding(15, 0, 0, 0);
            btnRaporlar.Size = new Size(199, 58);
            btnRaporlar.TabIndex = 0;
            btnRaporlar.Text = "            Raporlar";
            btnRaporlar.TextAlign = ContentAlignment.MiddleLeft;
            btnRaporlar.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnAyarlar);
            panel11.Location = new Point(3, 264);
            panel11.Name = "panel11";
            panel11.Size = new Size(173, 40);
            panel11.TabIndex = 1;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.FromArgb(2, 53, 53);
            btnAyarlar.FlatAppearance.BorderSize = 0;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAyarlar.ForeColor = Color.White;
            btnAyarlar.Image = Properties.Resources.settings_4_32;
            btnAyarlar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyarlar.Location = new Point(-13, -9);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Padding = new Padding(15, 0, 0, 0);
            btnAyarlar.Size = new Size(199, 58);
            btnAyarlar.TabIndex = 0;
            btnAyarlar.Text = "            Ayarlar";
            btnAyarlar.TextAlign = ContentAlignment.MiddleLeft;
            btnAyarlar.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnCikis);
            panel12.Location = new Point(3, 310);
            panel12.Name = "panel12";
            panel12.Size = new Size(173, 40);
            panel12.TabIndex = 1;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.FromArgb(2, 53, 53);
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCikis.ForeColor = Color.White;
            btnCikis.Image = Properties.Resources.exit_32;
            btnCikis.ImageAlign = ContentAlignment.MiddleLeft;
            btnCikis.Location = new Point(-13, -9);
            btnCikis.Name = "btnCikis";
            btnCikis.Padding = new Padding(15, 0, 0, 0);
            btnCikis.Size = new Size(199, 58);
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
            // pnlAnaPanel
            // 
            pnlAnaPanel.Dock = DockStyle.Fill;
            pnlAnaPanel.Location = new Point(180, 35);
            pnlAnaPanel.Name = "pnlAnaPanel";
            pnlAnaPanel.Size = new Size(1100, 685);
            pnlAnaPanel.TabIndex = 2;
            // 
            // FormHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(pnlAnaPanel);
            Controls.Add(menuContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormHomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            menuContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHome;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private FlowLayoutPanel menuContainer;
        private Button btnAnaSayfa;
        private System.Windows.Forms.Timer menuTransition;
        private Panel panel7;
        private Panel panel8;
        private Panel panel2;
        private Button btnProfil;
        private Panel panel9;
        private Button btnGunluk;
        private Panel panel10;
        private Button btnRaporlar;
        private Panel panel11;
        private Button btnAyarlar;
        private Panel panel12;
        private Button btnCikis;
        private Panel pnlAnaPanel;
        private Label label2;
    }
}