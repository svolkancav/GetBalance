namespace GetBalance.UI
{
    partial class FormGiris
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            btnYeniKullanici = new Button();
            btnHesapGiris = new Button();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnYeniKullanici
            // 
            btnYeniKullanici.BackColor = Color.FromArgb(15, 179, 35);
            btnYeniKullanici.FlatStyle = FlatStyle.Flat;
            btnYeniKullanici.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniKullanici.ForeColor = SystemColors.Control;
            btnYeniKullanici.Location = new Point(251, 277);
            btnYeniKullanici.Name = "btnYeniKullanici";
            btnYeniKullanici.Size = new Size(300, 73);
            btnYeniKullanici.TabIndex = 1;
            btnYeniKullanici.Text = "Yeni Bir Kullanıcıyım";
            btnYeniKullanici.UseVisualStyleBackColor = false;
            btnYeniKullanici.Click += btnYeniKullanici_Click;
            // 
            // btnHesapGiris
            // 
            btnHesapGiris.BackColor = Color.FromArgb(47, 47, 47);
            btnHesapGiris.FlatStyle = FlatStyle.Flat;
            btnHesapGiris.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapGiris.ForeColor = Color.White;
            btnHesapGiris.Location = new Point(251, 357);
            btnHesapGiris.Name = "btnHesapGiris";
            btnHesapGiris.Size = new Size(300, 73);
            btnHesapGiris.TabIndex = 2;
            btnHesapGiris.Text = "Zaten Bir Hesabım Var";
            btnHesapGiris.UseVisualStyleBackColor = false;
            btnHesapGiris.Click += btnHesapGiris_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 47, 47);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 58);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
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
            nightControlBox1.Location = new Point(589, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(333, 113);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 155);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(787, 587);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnHesapGiris);
            Controls.Add(btnYeniKullanici);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Healthy Diet";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnYeniKullanici;
        private Button btnHesapGiris;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private PictureBox pictureBox1;
    }
}