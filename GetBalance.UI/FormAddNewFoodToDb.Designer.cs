namespace GetBalance.UI
{
    partial class FormAddNewFoodToDb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewFoodToDb));
            pnlYeniYemekEkle = new Panel();
            txtBilgi = new Label();
            pictureBox1 = new PictureBox();
            btnKaydet = new Button();
            btnGeri = new Button();
            cmbKategoriler = new ComboBox();
            label1 = new Label();
            txtYag = new TextBox();
            txtProtein = new TextBox();
            txtKarb = new TextBox();
            txtPorsiyon = new TextBox();
            txtYemekAdi = new TextBox();
            pnlYeniYemekEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlYeniYemekEkle
            // 
            pnlYeniYemekEkle.BackColor = Color.MintCream;
            pnlYeniYemekEkle.Controls.Add(txtBilgi);
            pnlYeniYemekEkle.Controls.Add(pictureBox1);
            pnlYeniYemekEkle.Controls.Add(btnKaydet);
            pnlYeniYemekEkle.Controls.Add(btnGeri);
            pnlYeniYemekEkle.Controls.Add(cmbKategoriler);
            pnlYeniYemekEkle.Controls.Add(label1);
            pnlYeniYemekEkle.Controls.Add(txtYag);
            pnlYeniYemekEkle.Controls.Add(txtProtein);
            pnlYeniYemekEkle.Controls.Add(txtKarb);
            pnlYeniYemekEkle.Controls.Add(txtPorsiyon);
            pnlYeniYemekEkle.Controls.Add(txtYemekAdi);
            pnlYeniYemekEkle.Dock = DockStyle.Fill;
            pnlYeniYemekEkle.Location = new Point(5, 5);
            pnlYeniYemekEkle.Name = "pnlYeniYemekEkle";
            pnlYeniYemekEkle.Size = new Size(450, 590);
            pnlYeniYemekEkle.TabIndex = 0;
            // 
            // txtBilgi
            // 
            txtBilgi.Location = new Point(70, 459);
            txtBilgi.Name = "txtBilgi";
            txtBilgi.Size = new Size(310, 23);
            txtBilgi.TabIndex = 7;
            txtBilgi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(158, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnKaydet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(236, 529);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(201, 48);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGeri
            // 
            btnGeri.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGeri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeri.Location = new Point(14, 529);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(201, 48);
            btnGeri.TabIndex = 5;
            btnGeri.Text = "GERİ";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(70, 419);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(310, 23);
            cmbKategoriler.TabIndex = 4;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 149);
            label1.Name = "label1";
            label1.Size = new Size(310, 44);
            label1.TabIndex = 1;
            label1.Text = "YENİ YEMEK EKLE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtYag
            // 
            txtYag.BackColor = Color.White;
            txtYag.Location = new Point(70, 379);
            txtYag.Name = "txtYag";
            txtYag.PlaceholderText = "Yağ [gr]";
            txtYag.Size = new Size(310, 23);
            txtYag.TabIndex = 3;
            txtYag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProtein
            // 
            txtProtein.BackColor = Color.White;
            txtProtein.Location = new Point(70, 339);
            txtProtein.Name = "txtProtein";
            txtProtein.PlaceholderText = "Protein [gr]";
            txtProtein.Size = new Size(310, 23);
            txtProtein.TabIndex = 2;
            txtProtein.TextAlign = HorizontalAlignment.Center;
            // 
            // txtKarb
            // 
            txtKarb.BackColor = Color.White;
            txtKarb.Location = new Point(70, 299);
            txtKarb.Name = "txtKarb";
            txtKarb.PlaceholderText = "Karbonhidrat [gr]";
            txtKarb.Size = new Size(310, 23);
            txtKarb.TabIndex = 1;
            txtKarb.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPorsiyon
            // 
            txtPorsiyon.BackColor = Color.White;
            txtPorsiyon.Location = new Point(70, 259);
            txtPorsiyon.Name = "txtPorsiyon";
            txtPorsiyon.ReadOnly = true;
            txtPorsiyon.Size = new Size(310, 23);
            txtPorsiyon.TabIndex = 0;
            txtPorsiyon.Text = "100 gr";
            txtPorsiyon.TextAlign = HorizontalAlignment.Center;
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.BackColor = Color.White;
            txtYemekAdi.Location = new Point(70, 219);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.PlaceholderText = "Yemek Adı";
            txtYemekAdi.Size = new Size(310, 23);
            txtYemekAdi.TabIndex = 0;
            txtYemekAdi.TextAlign = HorizontalAlignment.Center;
            // 
            // FormAddNewFoodToDb
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 53, 53);
            ClientSize = new Size(460, 600);
            ControlBox = false;
            Controls.Add(pnlYeniYemekEkle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAddNewFoodToDb";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddNewFoodToDb";
            Load += FormAddNewFoodToDb_Load;
            pnlYeniYemekEkle.ResumeLayout(false);
            pnlYeniYemekEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlYeniYemekEkle;
        private Label label1;
        private TextBox txtKarb;
        private TextBox txtYemekAdi;
        private TextBox txtYag;
        private TextBox txtProtein;
        private ComboBox cmbKategoriler;
        private Button btnKaydet;
        private Button btnGeri;
        private PictureBox pictureBox1;
        private TextBox txtPorsiyon;
        private Label txtBilgi;
    }
}