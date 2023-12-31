﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DAL.Repositories;
using GetBalance.DATA.Entities;
using GetBalance.UI.Repositories;
using GetBalance.UI.Singeltons;

namespace GetBalance.UI
{
	public partial class FormUyeGirisi : Form
	{
		GenericRepository<User> _userRepo;

		UserDetailRepository userDetailrepository;

		UserTargetRepository userTargetRepository;

		UserManager userManager;

		public FormUyeGirisi()
		{
			InitializeComponent();
			_userRepo = new GenericRepository<User>();
			userTargetRepository = new UserTargetRepository();
			userDetailrepository = new UserDetailRepository();
			userManager = UserManager.Instance;
		}

		private void FormUyeGirisi_Load(object sender, EventArgs e)
		{

		}

		private void txtKullaniciAdi_Enter(object sender, EventArgs e)
		{
			if (txtKullaniciAdi.Text == "E-Posta ya da Kullanıcı Adı")
				txtKullaniciAdi.Text = "";
			txtKullaniciAdi.ForeColor = Color.Black;

		}

		private void txtSifre_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtKullaniciAdi_Leave(object sender, EventArgs e)
		{
			if (txtKullaniciAdi.Text == "")
				txtKullaniciAdi.Text = "E-Posta ya da Kullanıcı Adı";
			txtKullaniciAdi.ForeColor = Color.Silver;
		}

		char? none = null;
		private void txtSifre_Leave(object sender, EventArgs e)
		{
			if (txtSifre.Text == "")
			{
				txtSifre.Text = "Şifre";
				txtSifre.ForeColor = Color.Silver;
				txtSifre.PasswordChar = Convert.ToChar(none);
			}
		}


		private void txtSifre_Enter(object sender, EventArgs e)
		{
			if (txtSifre.Text == "Şifre")
			{
				txtSifre.Text = "";
				txtSifre.ForeColor = Color.Black;
				txtSifre.PasswordChar = '*';
			}
		}

		private void lnklblHesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormYeniKayit formYeniKayit = new FormYeniKayit();
			formYeniKayit.Show();
			this.Hide();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void lnklblSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormSifreYenile formSifreYenile = new FormSifreYenile();
			formSifreYenile.Show();
			this.Hide();
		}

		private void btnOturumAc_Click(object sender, EventArgs e)
		{
			string kullaniciAdi = txtKullaniciAdi.Text.Trim();
			string sifre = txtSifre.Text.Trim();

			if (kullaniciAdi == "E-Posta ya da Kullanıcı Adı" || kullaniciAdi == "")
			{
				MessageBox.Show("E-Posta ya da Kullanıcı Adı Girmelisiniz");
				return;
			}
			else if (sifre == "Şifre" || sifre == "")
			{
				MessageBox.Show("Şifre Girmelisiniz");
				return;
			}


			userManager.CurrentUser = _userRepo.GetByFilter(x => x.Email == kullaniciAdi && x.Password == sifre);


			if (userManager.CurrentUser == null)
			{
				MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
				return;
			}
			else
			{
				userManager.CurrentUser.UserDetail = userDetailrepository.GetAll().Find(us => us.UserId == userManager.CurrentUser.UserId);
				userManager.CurrentUser.UserDetail.UserTarget = userTargetRepository.GetAll().Find(ud => ud.UserDetailId == userManager.CurrentUser.UserDetail.UserDetailId);
				FormHomePage formAnaSayfa = new FormHomePage();
				formAnaSayfa.Show();
				this.Hide();
				}

		}


		private bool surukleniyor = false;
		private Point surukleBaslangicNoktasi;

		private void panel2_MouseUp(object sender, MouseEventArgs e)
		{
			surukleniyor = false;
		}

		private void panel2_MouseMove(object sender, MouseEventArgs e)
		{
			if (surukleniyor)
			{
				Point yeniKonum = this.Location;
				yeniKonum.X += e.X - surukleBaslangicNoktasi.X;
				yeniKonum.Y += e.Y - surukleBaslangicNoktasi.Y;
				this.Location = yeniKonum;
			}
		}

		private void txtSifre_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnOturumAc_Click(sender, e);
			}
		}
	}
}

