using GetBalance.UI.Extensions;
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
    public partial class FormVucutYagOrani : Form
    {
        public FormVucutYagOrani()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int boy = Convert.ToInt32(txtBoy.Text);
                int bel = Convert.ToInt32(txtBelCevresi.Text);
                int boyun = Convert.ToInt32(txtBoyunCevresi.Text);
                int kalca = Convert.ToInt32(txtKalcaCevresi.Text);
                string cinsiyet = rdbErkek.Checked ? "erkek" : "kadın";
                lblVYODeger.Text = "%"+CalculatorExtensions.VücutYağOraniHesapla(bel,boyun,kalca,boy,cinsiyet).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir değer giriniz !");
                txtBoy.Text = string.Empty;
                txtBelCevresi.Text = string.Empty;
                txtBoyunCevresi.Text = string.Empty;
                txtKalcaCevresi.Text= string.Empty;
                rdbErkek.Checked = false;
                rdbKadin.Checked = false;

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FormHesaplamalar frmHesaplamalar = new FormHesaplamalar();
            frmHesaplamalar.Show();
            this.Hide();
        }
    }
}
