﻿using GetBalance.DATA.Enums;
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
    public partial class FormGunlukKaloriIhtiyaci : Form
    {
        public FormGunlukKaloriIhtiyaci()
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
                int yas = Convert.ToInt32(txtYas.Text.Trim());
                ActivityLevel activity = (ActivityLevel)cmbxAktiviteSeviyesi.SelectedValue;
                lblGKIDeger.Text = CalculatorExtensions.GunlukKaloriIhtiyaci(boy, kilo, yas, activity, cinsiyet).ToString() + " Kalori/Gün";

            }
            catch (Exception)
            {

                MessageBox.Show("Geçerli bir değer giriniz !");
                txtBoy.Text = string.Empty;
                txtKilo.Text = string.Empty;
                cmbxAktiviteSeviyesi.SelectedIndex = -1;
                rdbErkek.Checked = false;
                rdbKadin.Checked = false;
                txtYas.Text = string.Empty;
            }
        }

        private void FormGunlukKaloriIhtiyaci_Load(object sender, EventArgs e)
        {
            cmbxAktiviteSeviyesi.DataSource = Enum.GetValues(typeof(ActivityLevel))
                .Cast<ActivityLevel>()
                .Select(x => new
                {
                    Value = (int)x,
                    DisplayName = x.DisplayName()
                }).ToList();
            cmbxAktiviteSeviyesi.DisplayMember = "DisplayName";
            cmbxAktiviteSeviyesi.ValueMember = "Value";

            cmbxAktiviteSeviyesi.SelectedIndex = -1;
        }
    }
}
