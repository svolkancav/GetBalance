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
    public partial class FormHedef : Form
    {
        public FormHedef()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            double hedeflenenProtein = double.Parse(txtHedefProtein.Text);
            double hedeflenenCarb = double.Parse(txtHedefCarbon.Text);
            double hedeflenenYag = double.Parse(txtHedefYag.Text);
            double hedeflenenKalori = double.Parse(txtHedefKalori.Text);

        }
    }
}
