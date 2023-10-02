using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetBalance.DATA;
using GetBalance.DATA.Entities;
using GetBalance.DATA.Enums;
using GetBalance.UI.Singeltons;

namespace GetBalance.UI
{

	public partial class FormYeniKayit : Form
	{
		UserManager userManager;

		public FormYeniKayit()
		{
			InitializeComponent();

			userManager = UserManager.Instance;

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
            }
            else if (sifreDuzeyi == "Orta")
            {
                lblOrta1.BackColor = Color.Yellow;
                lblOrta1.BringToFront();
                lblOrta1.Visible = true;
                lblCokZayif1.Visible = lblZayif1.Visible = lblGuclu.Visible = false;
            }
            else if (sifreDuzeyi == "Güçlü")
            {
               lblGuclu.BackColor = Color.Blue;
               lblGuclu.BringToFront();
               lblCokZayif1.Visible = lblZayif1.Visible = lblOrta1.Visible = false;
                lblGuclu.Visible = true;

               
            }
            else
            {
                lblCokZayif1.BackColor = Color.Red;
                lblCokZayif1.BringToFront();
                lblCokZayif1.Visible = true;
                lblZayif1.Visible = lblOrta1.Visible = lblGuclu.Visible = false;
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


    }

	
}




