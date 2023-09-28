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

namespace GetBalance.UI
{
    public partial class FormHomePage : Form
    {
        AnaSayfaControl anaSayfaControl;
        //GunlukControl gunlukControl;
        Form formGunluk;
        Form formHesaplamalar;
        //public delegate void transitionStarted(int kaymaMiktari);
        //public event transitionStarted transitionOldu;

        public Point downPoint = Point.Empty;

        User _user;
        public FormHomePage()
        {
            InitializeComponent();
            anaSayfaControl = new AnaSayfaControl();

        }

        public FormHomePage(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            formGunluk = new FormGunluk() { TopLevel = false, TopMost = true };
            formHesaplamalar = new FormHesaplamalar() { TopLevel = false, TopMost = true };

            pnlAnaPanel.Controls.Add(formGunluk);
            pnlAnaPanel.Controls.Add(formHesaplamalar);
        }

        #region SidePanelTransition

        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menuContainer.Width -= 10;
                formGunluk.Width += 10;
                //transitionOldu(10);

                if (menuContainer.Width <= 58)
                {
                    menuExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                menuContainer.Width += 10;
                formGunluk.Width -= 10;
                //transitionOldu(-10);

                if (menuContainer.Width >= 205)
                {

                    menuExpand = true;
                    menuTransition.Stop();

                }
            }
        }
        #endregion

        #region MenuButtons

        private void btnHome_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            //this.transitionOldu += formGunluk.

        }
        private void btnProfil_Click(object sender, EventArgs e)
        {

        }
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            anaSayfaControl.Show();
            //anaSayfaControl1.BringToFront();
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            HideAllForms();
            formGunluk.Show();
        }

        private void btnHesaplamalar_Click(object sender, EventArgs e)
        {
            HideAllForms();
            formHesaplamalar.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void HideAllForms()
        {
            foreach (Form item in pnlAnaPanel.Controls)
            {
                item.Hide();
            }
        }




    }
}
