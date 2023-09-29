using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GetBalance.UI
{
    public partial class FormAddNewFoodToDb : Form
    {
        //GenericRepository<FoodCategory> _categoryRepo;
        //GenericRepository<Food> _foodRepo;

        int karb, protein, yag;
        public FormAddNewFoodToDb()
        {
            InitializeComponent();
            //_categoryRepo = new GenericRepository<FoodCategory>();
        }

        private void FormAddNewFoodToDb_Load(object sender, EventArgs e)
        {
            CleanForm();
            //FillComboBox();


        }

        private void CleanForm()
        {
            txtYemekAdi.Text = string.Empty;
            txtKarb.Text = string.Empty;
            txtProtein.Text = string.Empty;
            txtYag.Text = string.Empty;
            cmbKategoriler.SelectedIndex = -1;
            cmbKategoriler.SelectedText = "Kategori seçiniz";
        }

        private void FillComboBox()
        {
            cmbKategoriler.Items.Clear();
            //cmbKategoriler.DataSource = _categoryRepo.GetAll();
            cmbKategoriler.ValueMember = "FoodCategoryId";
            cmbKategoriler.DisplayMember = "Name";

            cmbKategoriler.SelectedIndex = -1;
            cmbKategoriler.SelectedText = "Kategori seçiniz";

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (cmbKategoriler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kategori seçiniz!");
            }
            else
            {
                try
                {
                    karb = Convert.ToInt32(txtKarb.Text);
                    protein = Convert.ToInt32(txtProtein.Text);
                    yag = Convert.ToInt32(txtYag.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Geçerli bir değer giriniz!");
                    txtKarb.Text = string.Empty;
                    txtProtein.Text = string.Empty;
                    txtYag.Text = string.Empty;
                }
            }
            try
            {
                //_foodRepo.Add(new Food()
                //{
                //    Name = txtYemekAdi.Text.Trim(),
                //    Calories = CalculatorExtensions.KaloriHesapla(karb, protein, yag),
                //    Carbohydrate = karb,
                //    Protein = protein,
                //    Fat = yag,
                //    CategoryId = (int)cmbKategoriler.SelectedValue
                //});

                txtBilgi.ForeColor = Color.Green;
                txtBilgi.Text = "Yeni yemek eklendi!";
                CleanForm();

            }
            catch (Exception)
            {
                txtBilgi.ForeColor = Color.Red;
                txtBilgi.Text = "Yeni yemek eklerken bir hata oluştu!";
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
