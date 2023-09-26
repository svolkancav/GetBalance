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
    public partial class FormHesaplamalar : Form
    {
        public FormHesaplamalar()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string btnName = btn.Tag.ToString();



            switch (btnName)
            {
                case "VKI": VKIOpen(); break;

                case "BMR": BMROpen(); break;

                case "VücutYağOranı": VücutYağOranıOpen(); break;

                case "FFMI": FFMIOpen(); break;

                case "GünlükKaloriİhtiyacı": GünlükKaloriİhtiyacıOpen(); break;

                case "GünlükSuİhtiyacı": GünlükSuİhtiyacıOpen(); break;

                case "MaksimumKalpHızı": MaksimumKalpHızıOpen(); break;

            }
        }


        #region FormOpen

        FormKalpAtısHizi formKalpAtısHizi;
        FormGunlukKaloriIhtiyaci formGunlukKalori;
        FormVucutKitleEndex frmVKI;
        FormYagsizVucutKitlesi formYagsizVucutKitlesi;
        FormSuIhtiyaci formSuIhtiyaci;
        FormIdealKilo formIdealKilo;
        BazalMetabolizHiziForm bazalMetabolizHiziForm;
        FormVucutYagOrani formVucutYagOrani;
        private void MaksimumKalpHızıOpen()
        {
            formKalpAtısHizi = new FormKalpAtısHizi();
            formKalpAtısHizi.Show();
            this.Hide();

        }

        private void GünlükSuİhtiyacıOpen()
        {
            formSuIhtiyaci = new FormSuIhtiyaci();
            formSuIhtiyaci.Show();
            this.Hide();
        }

        private void İdealKiloOpen()
        {
            formIdealKilo = new FormIdealKilo();
            formIdealKilo.Show();
            this.Hide();
        }

        private void GünlükKaloriİhtiyacıOpen()
        {
            formGunlukKalori = new FormGunlukKaloriIhtiyaci();
            formGunlukKalori.Show();
            this.Hide();
        }

        private void FFMIOpen()
        {
            formYagsizVucutKitlesi = new FormYagsizVucutKitlesi();
            formYagsizVucutKitlesi.Show();
            this.Hide();
        }

        private void VücutYağOranıOpen()
        {
            formVucutYagOrani = new FormVucutYagOrani();
            formVucutYagOrani.Show();
            this.Hide();

        }

        private void BMROpen()
        {
            bazalMetabolizHiziForm = new BazalMetabolizHiziForm();
            bazalMetabolizHiziForm.Show();
            this.Hide();
        }

        private void VKIOpen()
        {
            frmVKI = new FormVucutKitleEndex();
            frmVKI.Show();
            this.Hide(); //TODO: hide yerine close için bakılacak.
        }

        #endregion


    }
}
