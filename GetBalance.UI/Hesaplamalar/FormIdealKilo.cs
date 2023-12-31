﻿using GetBalance.UI.Extensions;
using ReaLTaiizor.Controls;
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
    public partial class FormIdealKilo : Form
    {
        public FormIdealKilo()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int boy = Convert.ToInt32(txtBoy.Text.Trim());
                int kilo = Convert.ToInt32(txtKilo.Text.Trim());
                string cinsiyet = rdbErkek.Checked ? "erkek" : "kadın";
                decimal sonuc = CalculatorExtensions.IdealKiloHesapla(boy, cinsiyet);
                lblIdealKiloDeger.Text = sonuc.ToString();
                cpbIdealKilo.Value = Convert.ToInt64(sonuc);


            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir değer giriniz !");
                txtBoy.Text = string.Empty;
                txtKilo.Text = string.Empty;
                rdbErkek.Checked = false;
                rdbKadin.Checked = false;

            }
        }
    }


}
