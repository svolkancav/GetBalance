using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using GetBalance.DATA.Entities;
using GetBalance.DATA.Enums;
using GetBalance.UI.Singeltons;
using static System.Net.Mime.MediaTypeNames;

namespace GetBalance.UI
{


	public partial class FormYeniKayit : Form
	{
		UserManager userManager;
		GenericRepository<User> _userRepo;

		public FormYeniKayit()
		{
			InitializeComponent();

			userManager = UserManager.Instance;
			_userRepo = new GenericRepository<User>();

		}


		private void btnIleri_Click(object sender, EventArgs e)
		{
			string isim = txtIsim.Text.Trim();
			string soyisim = txtSoyisim.Text.Trim();
			string email = txtEmail.Text.Trim();
			string sifre = txtSifre.Text.Trim();
			string sifreTekrar = txtSifre2.Text.Trim();
			Gender gender = rdnErkek.Checked ? Gender.Male : Gender.Female;

			if (String.IsNullOrEmpty(isim) || String.IsNullOrEmpty(soyisim) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(sifre) || String.IsNullOrEmpty(sifreTekrar) || dtpDogumTarihi.Value == DateTime.Now)
			{
				MessageBox.Show("Lütfen tüm alanları doldurunuz.");
				return;
			}
			else if (sifre != sifreTekrar)
			{
				MessageBox.Show("Şifreler uyuşmuyor.");
				return;
			}
			else if (dtpDogumTarihi.Value > DateTime.Now)
			{
				MessageBox.Show("Doğum tarihi ileri bir tarih seçilemez!");
				return;
			}
			else if (_userRepo.GetByFilter(u => u.Email == email) != null)
			{
				MessageBox.Show("Bu e-posta adresi kullanılmaktadır.");
				return;
			}
			else if (CountSpace(txtIsim.Text) > 2)
			{
				MessageBox.Show("İsmi kontrol ediniz");
				return;
			}
			else if (CountSpace(txtSoyisim.Text) > 2)
			{
				MessageBox.Show("Soyisim kontrol ediniz");
				return;
			}

			int CountSpace(string text)
			{
				string[] parts = text.Split(' ');

				return parts.Length;
			}

			userManager.CurrentUser = new User()
			{
				Email = email,
				Password = sifre,
				UserDetail = new UserDetail()
				{
					FirstName = isim,
					LastName = soyisim,
					BirthDate = dtpDogumTarihi.Value,
					Gender = gender,
				}
			};


			FormYeniKayit2 formYeniKayit2 = new FormYeniKayit2();
			formYeniKayit2.Show();
			this.Hide();

		}



		private bool surukleniyor = false;
		private Point surukleBaslangicNoktasi;

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			surukleniyor = false;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (surukleniyor)
			{
				Point yeniKonum = this.Location;
				yeniKonum.X += e.X - surukleBaslangicNoktasi.X;
				yeniKonum.Y += e.Y - surukleBaslangicNoktasi.Y;
				this.Location = yeniKonum;
			}
		}



		private void FormYeniKayit_Load(object sender, EventArgs e)
		{
			txtSifre.PasswordChar = '*';
			txtSifre2.PasswordChar = '*';
			btnIleri.Enabled = false;
		}

		#region parola güvenlik seviyesi

		private string specialCharacter = "!@#$%^&*()-_+=[]{}|\\/?<>,.";
		private void txtSifre_TextChanged(object sender, EventArgs e)
		{
			string sifre = txtSifre.Text;
			string sifreDuzeyi = SifreGuvenligi(sifre);
			lblSifreDuzeyi.Text = "Parola Güvenlik Seviyesi: " + sifreDuzeyi;

			if (sifreDuzeyi == "Zayıf")
			{
				lblZayif1.BackColor = Color.Orange;
				lblZayif1.BringToFront();
				lblZayif1.Visible = true;
				lblCokZayif1.Visible = lblOrta1.Visible = lblGuclu.Visible = false;
				btnIleri.Enabled = false;
			}
			else if (sifreDuzeyi == "Orta")
			{
				lblOrta1.BackColor = Color.Yellow;
				lblOrta1.BringToFront();
				lblOrta1.Visible = true;
				lblCokZayif1.Visible = lblZayif1.Visible = lblGuclu.Visible = false;
				btnIleri.Enabled = true;
			}
			else if (sifreDuzeyi == "Güçlü")
			{
				lblGuclu.BackColor = Color.Blue;
				lblGuclu.BringToFront();
				lblCokZayif1.Visible = lblZayif1.Visible = lblOrta1.Visible = false;
				lblGuclu.Visible = true;
				btnIleri.Enabled = true;

			}
			else
			{
				lblCokZayif1.BackColor = Color.Red;
				lblCokZayif1.BringToFront();
				lblCokZayif1.Visible = true;
				lblZayif1.Visible = lblOrta1.Visible = lblGuclu.Visible = false;
				btnIleri.Enabled = false;
			}
		}




		private string SifreGuvenligi(string sifre)
		{
			if (sifre.Length < 6)
			{
				return "Çok Zayıf";
			}
			else if (sifre.Length >= 6 && sifre.Length <= 14)
			{
				bool hasDigit = sifre.Any(char.IsDigit);
				bool hasLetter = sifre.Any(char.IsLetter);
				bool hasSpecialCharacter = sifre.Any(c => specialCharacter.Contains(c));

				if (hasDigit && !hasLetter && !hasSpecialCharacter)
				{
					return "Zayıf";
				}
				else if (hasDigit && hasLetter && !hasSpecialCharacter)
				{
					return "Orta";
				}
				else if (hasDigit && hasLetter && hasSpecialCharacter)
				{
					return "Güçlü";
				}
			}
			return "Geçersiz";
		}
		#endregion


		private void btnGeri_Click(object sender, EventArgs e)
		{
			FormGiris formGiris = new FormGiris();
			formGiris.Show();
			this.Close();
		}

		int space = 0;
		private void txt_KeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox txt = (TextBox)sender;
			char ch = e.KeyChar;


			if (Char.IsLetter(e.KeyChar) && (txt.Text.Length == 0 || (txt.SelectionStart > 0 && txt.Text[txt.SelectionStart - 1] == ' ')))
			{
				e.KeyChar = Char.ToUpper(e.KeyChar);
			}
			else if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
			{
				e.Handled = true;
			}
			else if (Char.IsLetter(ch)) space = 0;



			if (ch == 32)
			{
				space++;
				if (space > 1)
				{
					e.Handled = true;
				}
			}
		}

		private void txtEmail_TextChanged(object sender, EventArgs e)
		{
			string email = txtEmail.Text.Trim();
			if (email.Contains("@") && email.Contains("."))
			{
				lblEmail.Visible = false;
			}
			else
			{

				lblEmail.Text = "Geçerli bir e posta adresi giriniz!";
				lblEmail.Visible = true;
			}
		}

		private void txt_Changed(object sender, EventArgs e)
		{
			string text1 = txtIsim.Text.Trim();
			if (text1.Length <= 1)
			{
				lblAd.Text = "En az iki karakter girmelisinz.";
				lblAd.Visible = true;
			}
			else
			{
				lblAd.Visible = false;
			}

			string text2 = txtSoyisim.Text.Trim();
			if (text2.Length <= 1)
			{
				lblSoyad.Text = "En az iki karakter girmelisinz.";
				lblSoyad.Visible = true;
			}
			else
			{
				lblSoyad.Visible = false;
			}
		}
	}
}




