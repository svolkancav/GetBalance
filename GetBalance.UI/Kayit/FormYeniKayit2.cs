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
using GetBalance.DATA.Entities;
using GetBalance.DATA.Enums;
using GetBalance.UI.Extensions;
using GetBalance.UI.Singeltons;
using Microsoft.VisualBasic.ApplicationServices;
using User = GetBalance.DATA.Entities.User;

namespace GetBalance.UI
{
    public partial class FormYeniKayit2 : Form

    {
        GenericRepository<User> _userRepo;
        UserManager userManager;


        FormYeniKayit _yeniKayit;
        public FormYeniKayit2()
        {
            InitializeComponent();

            _userRepo = new GenericRepository<User>();
            userManager = UserManager.Instance;

        }




        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            try
            {
                double height = Convert.ToDouble(txtBoy.Text.Trim());
                double weight = Convert.ToDouble(txtKilo.Text.Trim());
                double neckCircumference = Convert.ToDouble(txtBoyunCevresi.Text.Trim());
                double waistCircumference = Convert.ToDouble(txtBelCevresi.Text.Trim());
                double hipCircumference = Convert.ToDouble(txtKalcaCevresi.Text.Trim());
                ActivityLevel activityLevel = (ActivityLevel)cbxAktiviteSeviyesi.SelectedValue;
                TrainingLevel trainingLevel = (TrainingLevel)cmbTraining.SelectedValue;

                if (height <= 0 || weight <= 0 || neckCircumference <= 0 || waistCircumference <= 0 || hipCircumference <= 0 || cbxAktiviteSeviyesi.SelectedIndex == -1 || cmbTraining.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanlara geçerli değerler giriniz.");
                    return;
                }
                if (height > 250 || weight > 400 || neckCircumference > 70 || waistCircumference > 200 || hipCircumference > 200)
                {
                    MessageBox.Show("Lütfen insani değerler giriniz! :)");
                    return;
                }
                UserDetail userDetail = new UserDetail();

                userManager.CurrentUser.UserDetail.Height = height;
                userManager.CurrentUser.UserDetail.CurrentWeight = weight;
                userManager.CurrentUser.UserDetail.NeckCircumference = neckCircumference;
                userManager.CurrentUser.UserDetail.WaistCircumference = waistCircumference;
                userManager.CurrentUser.UserDetail.HipCircumference = hipCircumference;
                userManager.CurrentUser.UserDetail.TrainingLevel = trainingLevel;


                _userRepo.Add(userManager.CurrentUser);

                FormHomePage formAnaSayfa = new FormHomePage();
                formAnaSayfa.Show();
                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Kaydolurken hata oluştu. Tekrar deneyiniz.");
                ClearForm();
            }


        }

        private void ClearForm()
        {
            txtBoy.Text = txtBelCevresi.Text = txtBoyunCevresi.Text = txtKalcaCevresi.Text = txtKilo.Text = string.Empty;
            cmbTraining.SelectedItem = cbxAktiviteSeviyesi.SelectedItem = null;
        }

        private void FormYeniKayit2_Load(object sender, EventArgs e)
        {
            cbxAktiviteSeviyesi.DataSource = Enum.GetValues(typeof(ActivityLevel))
                .Cast<ActivityLevel>()
                .Select(x => new
                {
                    Value = (int)x,
                    DisplayName = x.DisplayName()
                }).ToList();
            cbxAktiviteSeviyesi.DisplayMember = "DisplayName";
            cbxAktiviteSeviyesi.ValueMember = "Value";

            cbxAktiviteSeviyesi.SelectedIndex = -1;


            cmbTraining.DataSource = Enum.GetValues(typeof(TrainingLevel))
                .Cast<TrainingLevel>()
                .Select(x => new
                {
                    Value = (int)x,
                    DisplayName = x.DisplayName()
                }).ToList();
            cmbTraining.DisplayMember = "DisplayName";
            cmbTraining.ValueMember = "Value";

            cmbTraining.SelectedIndex = -1;


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
    }
}
