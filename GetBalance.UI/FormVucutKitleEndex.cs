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
    public partial class FormVucutKitleEndex : Form
    {
        public FormVucutKitleEndex()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {


            // TODO : boy kilo doğru girilip girilmediği kontrol edilecek.

            try
            {
                int boy = Convert.ToInt32(txtBoy.Text);
                int kilo = Convert.ToInt32(txtKilo.Text);
                lblVKIDeger.Text = CalculatorExtensions.VKİHesapla(kilo, boy).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir değer giriniz !");
                txtBoy.Text = string.Empty;
                txtKilo.Text = string.Empty;

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            //TODO: Hesaplama Sayfasına Geri Dönmeli
            FormHesaplamalar frmHesaplamalar = new FormHesaplamalar();
            frmHesaplamalar.Show();
            this.Hide(); ////TODO: Hide dedim kapanıp yeni form açılma işine bakmak gerek;

        }

    }
}
