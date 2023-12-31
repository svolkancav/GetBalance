﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetBalance.DATA.Entities;
using GetBalance.UI.Singeltons;

namespace GetBalance.UI
{


    public partial class FormProfil : Form
    {
        UserManager userManager;

        OpenFileDialog openFileDialog = new OpenFileDialog();
        public FormProfil()
        {
            InitializeComponent();
            userManager = UserManager.Instance;
        }

        Form formBenimKilom, formIletisimveGizlilik, formBizeUlasin, formHatirlatici, formAyarlar;
        public Point downPoint = Point.Empty;

        private void FormProfil_Load(object sender, EventArgs e)
        {
            formBenimKilom = new FormBenimKilom() { TopLevel = false, TopMost = true };
            formIletisimveGizlilik = new FormIletisimVeGizlilik() { TopLevel = false, TopMost = true };
            formBizeUlasin = new FormBizeUlasin() { TopLevel = false, TopMost = true };
            formHatirlatici = new FormHatirlatici() { TopLevel = false, TopMost = true };
            formAyarlar = new FormAyarlar() { TopLevel = false, TopMost = true };

            pnlProfil2.Controls.Add(formHatirlatici);
            pnlProfil2.Controls.Add(formBenimKilom);
            pnlProfil2.Controls.Add(formIletisimveGizlilik);
            pnlProfil2.Controls.Add(formBizeUlasin);
            pnlProfil2.Controls.Add(formAyarlar);

            User user = userManager.CurrentUser;

            lblKullaniciAdi.Text = user.UserDetail.FirstName + " " + user.UserDetail.LastName;
            lblMail.Text = user.Email;


        }
        private void HideAllForms()
        {
            foreach (Form item in pnlProfil2.Controls)
            {
                item.Hide();
            }
        }
        private void btnBenimKilom_Click(object sender, EventArgs e)
        {
            HideAllForms();
            formBenimKilom.Show();
        }

        private void btnGizlilik_Click(object sender, EventArgs e)
        {
            HideAllForms();
            formIletisimveGizlilik.Show();
        }

        private void btnBizeUlasin_Click(object sender, EventArgs e)
        {

            HideAllForms();
            formBizeUlasin.Show();
        }

        // Seçilen resmi PictureBox içine yükle
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnHatirlatici_Click(object sender, EventArgs e)
        {
            HideAllForms();
            formHatirlatici.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HideAllForms();
            formAyarlar.Show();
        }

        //Mail sayfasını aç
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //string mailto = string.Format("mailto:{0}?Subject={1}&Body={2}", "mail@mail.com.tr", "Subject of message", "This is a body of a message");

            //mailto = Uri.EscapeUriString(mailto);
            //System.Diagnostics.Process.Start(mailto);

        }


    }


}
