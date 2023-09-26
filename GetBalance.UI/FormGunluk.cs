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
    public partial class FormGunluk : Form
    {
        bool kahvaltiAcikMi, ogleAcikMi, aksamAcikMi, aperatifAcikMi = false;
        public FormGunluk()
        {
            InitializeComponent();
            pnlKahveLsv.Visible = pnlOgleLsv.Visible = pnlAksamLsv.Visible = pnlAperatifLsv.Visible = false;
        }

        private void btnKahvalti_Click(object sender, EventArgs e)
        {
            pnlKahveLsv.Visible = !kahvaltiAcikMi;
            kahvaltiAcikMi = !kahvaltiAcikMi;
        }

        private void btnOgleYemegi_Click(object sender, EventArgs e)
        {
            pnlOgleLsv.Visible = !ogleAcikMi;
            ogleAcikMi = !ogleAcikMi;
        }

        private void btnAksamYmegi_Click(object sender, EventArgs e)
        {
            pnlAksamLsv.Visible = !aksamAcikMi;
            aksamAcikMi = !aksamAcikMi;
        }

        private void btnAperatif_Click(object sender, EventArgs e)
        {
            pnlAperatifLsv.Visible = !aperatifAcikMi;
            aperatifAcikMi = !aperatifAcikMi;
        }
    }
}
