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
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }

        Form formBenimKilom, formIletisimveGizlilik, formBizeUlasin;
        public Point downPoint = Point.Empty;

        private void FormProfil_Load(object sender, EventArgs e)
        {
            formBenimKilom = new FormBenimKilom() { TopLevel = false, TopMost = true };
            formIletisimveGizlilik = new FormIletisimVeGizlilik() { TopLevel = false, TopMost = true };
            formBizeUlasin = new FormBizeUlasin() { TopLevel = false, TopMost = true };

            pnlProfil2.Controls.Add(formBenimKilom);
            pnlProfil2.Controls.Add(formIletisimveGizlilik);
            pnlProfil2.Controls.Add(formBizeUlasin);

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
    }
}
