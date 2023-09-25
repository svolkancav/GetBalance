using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetBalance.UI
{
    public partial class FormUyeGirisi : Form
    {
        public FormUyeGirisi()
        {
            InitializeComponent();
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
    }
}

