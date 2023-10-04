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
using GetBalance.DATA.Entities;

namespace GetBalance.UI
{
	public partial class FormSifreYenile : Form
	{
		GenericRepository<User> repoUsers;
		public FormSifreYenile()
		{
			InitializeComponent();

			repoUsers = new GenericRepository<User>();
		}


		private bool surukleniyor = false;
		private Point surukleBaslangicNoktasi;
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

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			surukleniyor = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormUyeGirisi formUyeGirisi = new FormUyeGirisi();
			formUyeGirisi.Show();
			this.Close();
		}

		private void btnSifreYenile_Click(object sender, EventArgs e)
		{
			string email = txtEmailYenileme.Text.Trim();
			User? user = repoUsers.GetByFilter(x => x.Email == email);

			if (string.IsNullOrEmpty(email))
			{
				MessageBox.Show("Lütfen email adresinizi giriniz.");
				return;
			}else if (!email.Contains("@")&& !email.Contains("."))
			{
				MessageBox.Show("Lütfen geçerli bir email adresi giriniz.");
				return;
			}else if (user == null)
			{
				MessageBox.Show("Bu email adresi ile kayıtlı bir kullanıcı bulunamadı.");
			}

			MessageBox.Show("Şifre yenileme bağlantısı mailinize gönderilmiştir");
		}
	}
}
