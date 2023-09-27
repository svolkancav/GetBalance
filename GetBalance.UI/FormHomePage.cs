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
        public Point downPoint = Point.Empty;

        User _user;
        public FormHomePage()
        {
            InitializeComponent();
            anaSayfaControl = new AnaSayfaControl();
            //gunlukControl = new GunlukControl();
        }

        public FormHomePage(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {
            formGunluk = new FormGunluk() { TopLevel = false, TopMost = true };

        }

        #region SidePanelTransition

        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menuContainer.Width -= 10;
                formGunluk.Width += 10;

                if (menuContainer.Width <= 51)
                {
                    menuExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                menuContainer.Width += 10;
                formGunluk.Width -= 10;
                if (menuContainer.Width >= 180)
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
            //gunlukControl1.BringToFront();
            //gunlukControl1.Show();

            pnlAnaPanel.Controls.Add(formGunluk);
            formGunluk.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion




    }
}
