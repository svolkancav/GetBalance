namespace GetBalance.UI
{
	partial class FormAddFood
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
			panel1 = new Panel();
			lblPorsiyonDetayi = new Label();
			txtPosiyonMiktari = new TextBox();
			btnYeniYemekEkle = new Button();
			btnOguneEkle = new Button();
			lsvFoods = new ListView();
			cmbKategoriler = new ComboBox();
			txtYemekAra = new TextBox();
			pbKapat = new PictureBox();
			label1 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbKapat).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.WhiteSmoke;
			panel1.Controls.Add(lblPorsiyonDetayi);
			panel1.Controls.Add(txtPosiyonMiktari);
			panel1.Controls.Add(btnYeniYemekEkle);
			panel1.Controls.Add(btnOguneEkle);
			panel1.Controls.Add(lsvFoods);
			panel1.Controls.Add(cmbKategoriler);
			panel1.Controls.Add(txtYemekAra);
			panel1.Location = new Point(6, 61);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(514, 732);
			panel1.TabIndex = 0;
			// 
			// lblPorsiyonDetayi
			// 
			lblPorsiyonDetayi.Location = new Point(272, 607);
			lblPorsiyonDetayi.Name = "lblPorsiyonDetayi";
			lblPorsiyonDetayi.Size = new Size(227, 27);
			lblPorsiyonDetayi.TabIndex = 5;
			lblPorsiyonDetayi.Text = "Porsiyon Birimi";
			lblPorsiyonDetayi.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtPosiyonMiktari
			// 
			txtPosiyonMiktari.Location = new Point(16, 607);
			txtPosiyonMiktari.Margin = new Padding(3, 4, 3, 4);
			txtPosiyonMiktari.Name = "txtPosiyonMiktari";
			txtPosiyonMiktari.PlaceholderText = "Porsiyon Miktarı Giriniz";
			txtPosiyonMiktari.Size = new Size(229, 27);
			txtPosiyonMiktari.TabIndex = 4;
			// 
			// btnYeniYemekEkle
			// 
			btnYeniYemekEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnYeniYemekEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnYeniYemekEkle.Location = new Point(270, 651);
			btnYeniYemekEkle.Margin = new Padding(3, 4, 3, 4);
			btnYeniYemekEkle.Name = "btnYeniYemekEkle";
			btnYeniYemekEkle.Size = new Size(230, 64);
			btnYeniYemekEkle.TabIndex = 3;
			btnYeniYemekEkle.Text = "YENİ YEMEK EKLE";
			btnYeniYemekEkle.UseVisualStyleBackColor = true;
			btnYeniYemekEkle.Click += btnYeniYemekEkle_Click;
			// 
			// btnOguneEkle
			// 
			btnOguneEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnOguneEkle.Enabled = false;
			btnOguneEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnOguneEkle.Location = new Point(16, 651);
			btnOguneEkle.Margin = new Padding(3, 4, 3, 4);
			btnOguneEkle.Name = "btnOguneEkle";
			btnOguneEkle.Size = new Size(230, 64);
			btnOguneEkle.TabIndex = 3;
			btnOguneEkle.Text = "SEÇİLİ YEMEĞİ ÖĞÜNE EKLE";
			btnOguneEkle.UseVisualStyleBackColor = true;
			btnOguneEkle.Click += btnOguneEkle_Click;
			// 
			// lsvFoods
			// 
			lsvFoods.Location = new Point(16, 55);
			lsvFoods.Margin = new Padding(3, 4, 3, 4);
			lsvFoods.Name = "lsvFoods";
			lsvFoods.Size = new Size(483, 543);
			lsvFoods.TabIndex = 2;
			lsvFoods.UseCompatibleStateImageBehavior = false;
			lsvFoods.SelectedIndexChanged += lsvFoods_SelectedIndexChanged;
			// 
			// cmbKategoriler
			// 
			cmbKategoriler.FormattingEnabled = true;
			cmbKategoriler.Location = new Point(329, 16);
			cmbKategoriler.Margin = new Padding(3, 4, 3, 4);
			cmbKategoriler.Name = "cmbKategoriler";
			cmbKategoriler.Size = new Size(170, 28);
			cmbKategoriler.TabIndex = 1;
			cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
			// 
			// txtYemekAra
			// 
			txtYemekAra.Location = new Point(16, 16);
			txtYemekAra.Margin = new Padding(3, 4, 3, 4);
			txtYemekAra.Name = "txtYemekAra";
			txtYemekAra.PlaceholderText = "Yemek Ara";
			txtYemekAra.Size = new Size(306, 27);
			txtYemekAra.TabIndex = 0;
			txtYemekAra.TextChanged += txtYemekAra_TextChanged;
			// 
			// pbKapat
			// 
			pbKapat.Cursor = Cursors.Hand;
			pbKapat.Image = Properties.Resources.close_window_32__1_;
			pbKapat.Location = new Point(480, 11);
			pbKapat.Margin = new Padding(3, 4, 3, 4);
			pbKapat.Name = "pbKapat";
			pbKapat.Size = new Size(32, 32);
			pbKapat.SizeMode = PictureBoxSizeMode.AutoSize;
			pbKapat.TabIndex = 4;
			pbKapat.TabStop = false;
			pbKapat.Click += pbKapat_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BorderStyle = BorderStyle.FixedSingle;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(194, 11);
			label1.Name = "label1";
			label1.Size = new Size(153, 39);
			label1.TabIndex = 5;
			label1.Text = "YEMEKLER";
			// 
			// FormAddFood
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(2, 53, 53);
			ClientSize = new Size(526, 800);
			Controls.Add(label1);
			Controls.Add(pbKapat);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormAddFood";
			Padding = new Padding(6, 7, 6, 7);
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormAddFood";
			Load += FormAddFood_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbKapat).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private TextBox txtYemekAra;
		private Button btnYeniYemekEkle;
		private Button btnOguneEkle;
		private ListView lsvFoods;
		private ComboBox cmbKategoriler;
		private PictureBox pbKapat;
		private Label label1;
		private TextBox txtPosiyonMiktari;
		private Label lblPorsiyonDetayi;
	}
}