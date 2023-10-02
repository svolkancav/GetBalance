namespace GetBalance.UI
{
	partial class FormYeniKayit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYeniKayit));
			panel1 = new Panel();
			nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
			panel2 = new Panel();
			lblYeniHesapOlustur = new Label();
			txtIsim = new TextBox();
			txtSoyisim = new TextBox();
			txtEmail = new TextBox();
			txtSifre = new TextBox();
			txtSifre2 = new TextBox();
			dtpDogumTarihi = new DateTimePicker();
			rdnErkek = new RadioButton();
			rdnKadin = new RadioButton();
			btnIleri = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			lblSifreDuzeyi = new Label();
			lblZayif1 = new Label();
			lblCokZayif1 = new Label();
			lblOrta1 = new Label();
			lblGuclu = new Label();
			btnGeri = new Button();
			lblEmail = new Label();
			lblSoyad = new Label();
			lblAd = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(47, 47, 47);
			panel1.Controls.Add(nightControlBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 38);
			panel1.TabIndex = 0;
			panel1.MouseMove += panel1_MouseMove;
			panel1.MouseUp += panel1_MouseUp;
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
			nightControlBox1.Location = new Point(661, 0);
			nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
			nightControlBox1.MaximizeHoverForeColor = Color.White;
			nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
			nightControlBox1.MinimizeHoverForeColor = Color.White;
			nightControlBox1.Name = "nightControlBox1";
			nightControlBox1.Size = new Size(139, 31);
			nightControlBox1.TabIndex = 5;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(2, 53, 53);
			panel2.Controls.Add(lblYeniHesapOlustur);
			panel2.Location = new Point(0, 32);
			panel2.Name = "panel2";
			panel2.Size = new Size(800, 48);
			panel2.TabIndex = 1;
			// 
			// lblYeniHesapOlustur
			// 
			lblYeniHesapOlustur.AutoSize = true;
			lblYeniHesapOlustur.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblYeniHesapOlustur.ForeColor = Color.White;
			lblYeniHesapOlustur.Location = new Point(343, 12);
			lblYeniHesapOlustur.Name = "lblYeniHesapOlustur";
			lblYeniHesapOlustur.Size = new Size(141, 20);
			lblYeniHesapOlustur.TabIndex = 0;
			lblYeniHesapOlustur.Text = "Yeni Hesap Oluştur";
			// 
			// txtIsim
			// 
			txtIsim.Location = new Point(319, 119);
			txtIsim.Name = "txtIsim";
			txtIsim.Size = new Size(200, 23);
			txtIsim.TabIndex = 2;
			txtIsim.TextChanged += txt_Changed;
			txtIsim.KeyPress += txt_KeyPress;
			// 
			// txtSoyisim
			// 
			txtSoyisim.Location = new Point(319, 165);
			txtSoyisim.Name = "txtSoyisim";
			txtSoyisim.Size = new Size(200, 23);
			txtSoyisim.TabIndex = 3;
			txtSoyisim.TextChanged += txt_Changed;
			txtSoyisim.KeyPress += txt_KeyPress;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(319, 204);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(200, 23);
			txtEmail.TabIndex = 4;
			txtEmail.TextChanged += txtEmail_TextChanged;
			// 
			// txtSifre
			// 
			txtSifre.Location = new Point(319, 243);
			txtSifre.Name = "txtSifre";
			txtSifre.Size = new Size(200, 23);
			txtSifre.TabIndex = 5;
			txtSifre.TextChanged += txtSifre_TextChanged;
			// 
			// txtSifre2
			// 
			txtSifre2.Location = new Point(319, 281);
			txtSifre2.Name = "txtSifre2";
			txtSifre2.Size = new Size(200, 23);
			txtSifre2.TabIndex = 6;
			// 
			// dtpDogumTarihi
			// 
			dtpDogumTarihi.Location = new Point(319, 324);
			dtpDogumTarihi.Name = "dtpDogumTarihi";
			dtpDogumTarihi.Size = new Size(200, 23);
			dtpDogumTarihi.TabIndex = 7;
			// 
			// rdnErkek
			// 
			rdnErkek.AutoSize = true;
			rdnErkek.Location = new Point(319, 369);
			rdnErkek.Name = "rdnErkek";
			rdnErkek.Size = new Size(53, 19);
			rdnErkek.TabIndex = 8;
			rdnErkek.TabStop = true;
			rdnErkek.Text = "Erkek";
			rdnErkek.UseVisualStyleBackColor = true;
			// 
			// rdnKadin
			// 
			rdnKadin.AutoSize = true;
			rdnKadin.Location = new Point(398, 369);
			rdnKadin.Name = "rdnKadin";
			rdnKadin.Size = new Size(55, 19);
			rdnKadin.TabIndex = 9;
			rdnKadin.TabStop = true;
			rdnKadin.Text = "Kadın";
			rdnKadin.UseVisualStyleBackColor = true;
			// 
			// btnIleri
			// 
			btnIleri.BackColor = Color.FromArgb(15, 194, 192);
			btnIleri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnIleri.ForeColor = Color.White;
			btnIleri.Image = (Image)resources.GetObject("btnIleri.Image");
			btnIleri.ImageAlign = ContentAlignment.MiddleRight;
			btnIleri.Location = new Point(403, 403);
			btnIleri.Name = "btnIleri";
			btnIleri.Size = new Size(131, 35);
			btnIleri.TabIndex = 10;
			btnIleri.Text = "İleri";
			btnIleri.UseVisualStyleBackColor = false;
			btnIleri.Click += btnIleri_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(249, 120);
			label1.Name = "label1";
			label1.Size = new Size(39, 21);
			label1.TabIndex = 11;
			label1.Text = "Ad: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(223, 165);
			label2.Name = "label2";
			label2.Size = new Size(65, 21);
			label2.TabIndex = 12;
			label2.Text = "Soyad: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(223, 206);
			label3.Name = "label3";
			label3.Size = new Size(61, 21);
			label3.TabIndex = 13;
			label3.Text = "Email: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(231, 245);
			label4.Name = "label4";
			label4.Size = new Size(53, 21);
			label4.TabIndex = 14;
			label4.Text = "Şifre: ";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(165, 283);
			label5.Name = "label5";
			label5.Size = new Size(119, 21);
			label5.TabIndex = 15;
			label5.Text = "Yeniden Şifre: ";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.Location = new Point(162, 324);
			label6.Name = "label6";
			label6.Size = new Size(118, 21);
			label6.TabIndex = 16;
			label6.Text = "Doğum Tarihi:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(209, 369);
			label7.Name = "label7";
			label7.Size = new Size(79, 21);
			label7.TabIndex = 17;
			label7.Text = "Cinsiyet: ";
			// 
			// lblSifreDuzeyi
			// 
			lblSifreDuzeyi.AutoSize = true;
			lblSifreDuzeyi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			lblSifreDuzeyi.Location = new Point(534, 246);
			lblSifreDuzeyi.Name = "lblSifreDuzeyi";
			lblSifreDuzeyi.Size = new Size(0, 15);
			lblSifreDuzeyi.TabIndex = 18;
			// 
			// lblZayif1
			// 
			lblZayif1.AutoSize = true;
			lblZayif1.Location = new Point(525, 270);
			lblZayif1.Name = "lblZayif1";
			lblZayif1.Size = new Size(127, 15);
			lblZayif1.TabIndex = 19;
			lblZayif1.Text = "                                        ";
			// 
			// lblCokZayif1
			// 
			lblCokZayif1.AutoSize = true;
			lblCokZayif1.Location = new Point(525, 270);
			lblCokZayif1.Name = "lblCokZayif1";
			lblCokZayif1.Size = new Size(67, 15);
			lblCokZayif1.TabIndex = 20;
			lblCokZayif1.Text = "                    ";
			// 
			// lblOrta1
			// 
			lblOrta1.AutoSize = true;
			lblOrta1.Location = new Point(525, 270);
			lblOrta1.Name = "lblOrta1";
			lblOrta1.Size = new Size(187, 15);
			lblOrta1.TabIndex = 21;
			lblOrta1.Text = "                                                            ";
			// 
			// lblGuclu
			// 
			lblGuclu.AutoSize = true;
			lblGuclu.Location = new Point(525, 270);
			lblGuclu.Name = "lblGuclu";
			lblGuclu.Size = new Size(247, 15);
			lblGuclu.TabIndex = 22;
			lblGuclu.Text = "                                                                                ";
			// 
			// btnGeri
			// 
			btnGeri.BackColor = Color.FromArgb(15, 194, 192);
			btnGeri.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			btnGeri.ForeColor = Color.White;
			btnGeri.ImageAlign = ContentAlignment.MiddleRight;
			btnGeri.Location = new Point(249, 403);
			btnGeri.Name = "btnGeri";
			btnGeri.Size = new Size(131, 35);
			btnGeri.TabIndex = 10;
			btnGeri.Text = "Geri";
			btnGeri.UseVisualStyleBackColor = false;
			btnGeri.Click += btnGeri_Click;
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Location = new Point(525, 207);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(247, 15);
			lblEmail.TabIndex = 23;
			lblEmail.Text = "                                                                                ";
			// 
			// lblSoyad
			// 
			lblSoyad.AutoSize = true;
			lblSoyad.Location = new Point(525, 168);
			lblSoyad.Name = "lblSoyad";
			lblSoyad.Size = new Size(247, 15);
			lblSoyad.TabIndex = 24;
			lblSoyad.Text = "                                                                                ";
			// 
			// lblAd
			// 
			lblAd.AutoSize = true;
			lblAd.Location = new Point(525, 122);
			lblAd.Name = "lblAd";
			lblAd.Size = new Size(247, 15);
			lblAd.TabIndex = 25;
			lblAd.Text = "                                                                                ";
			// 
			// FormYeniKayit
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblAd);
			Controls.Add(lblSoyad);
			Controls.Add(lblEmail);
			Controls.Add(lblGuclu);
			Controls.Add(lblOrta1);
			Controls.Add(lblCokZayif1);
			Controls.Add(lblZayif1);
			Controls.Add(lblSifreDuzeyi);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnGeri);
			Controls.Add(btnIleri);
			Controls.Add(rdnKadin);
			Controls.Add(rdnErkek);
			Controls.Add(dtpDogumTarihi);
			Controls.Add(txtSifre2);
			Controls.Add(txtSifre);
			Controls.Add(txtEmail);
			Controls.Add(txtSoyisim);
			Controls.Add(txtIsim);
			Controls.Add(panel2);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			MaximizeBox = false;
			Name = "FormYeniKayit";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FormYeniKayit";
			Load += FormYeniKayit_Load;
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}


		#endregion

		private Panel panel1;
		private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
		private Panel panel2;
		private Label lblYeniHesapOlustur;
		private TextBox txtIsim;
		private TextBox txtSoyisim;
		private TextBox txtEmail;
		private TextBox txtSifre;
		private TextBox txtSifre2;
		private DateTimePicker dtpDogumTarihi;
		private RadioButton rdnErkek;
		private RadioButton rdnKadin;
		private Button btnIleri;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label lblSifreDuzeyi;
		private Label lblCokZayif;
		private Label label11;
		private Label lblZayif;
		private Label lblzOrta;
		private Label lblZayif1;
		private Label lblCokZayif1;
		private Label lblOrta1;
		private Label lblGuclu;
		private Button btnGeri;
		private Label lblEmail;
		private Label lblSoyad;
		private Label lblAd;
	}
}