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
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
            AnaSayfaControl anaSayfaControl = new AnaSayfaControl();
            anaSayfaControl.Show();
        }

        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menuContainer.Width -= 10;
                if (menuContainer.Width <= 45)
                {
                    menuExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                menuContainer.Width += 10;
                if (menuContainer.Width >= 149)
                {

                    menuExpand = true;
                    menuTransition.Stop();

                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

        }

        private void btnBen_Click(object sender, EventArgs e)
        {
            //profilControl1.BringToFront();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            // anaSayfaControl1.BringToFront();
        }
    }
}
