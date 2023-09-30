using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
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
        GenericRepository<FoodCategory> _categoryRepo;
        GenericRepository<Food> _foodRepo;
        GenericRepository<Portion> _portionRepo;
        OpenFileDialog openFileDialog;
        int karb, protein, yag, porsiyonMiktari;
        public FormAddNewFoodToDb()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            _categoryRepo = new GenericRepository<FoodCategory>();
            _foodRepo = new GenericRepository<Food>();
            _portionRepo = new GenericRepository<Portion>();
        }

        private void FormAddNewFoodToDb_Load(object sender, EventArgs e)
        {
            CleanForm();
            FillComboBoxKategoriler();
            FillComboBoxPorsiyonlar();

        }

        private void CleanForm()
        {
            txtYemekAdi.Text = string.Empty;
            txtPorsiyonMiktari.Text = string.Empty;
            txtKarb.Text = string.Empty;
            txtProtein.Text = string.Empty;
            txtYag.Text = string.Empty;
            cmbPorsiyonlar.SelectedIndex = -1;
            cmbPorsiyonlar.SelectedText = "Seçiniz";
            cmbKategoriler.SelectedIndex = -1;
            cmbKategoriler.SelectedText = "Kategori seçiniz";
        }
        private void FillComboBoxPorsiyonlar()
        {
            cmbPorsiyonlar.Items.Clear();
            cmbPorsiyonlar.DataSource = Enum.GetValues(typeof(PortionName));

            cmbPorsiyonlar.SelectedIndex = -1;
            cmbPorsiyonlar.SelectedText = "Seçiniz";

        }

        private void FillComboBoxKategoriler()
        {
            cmbKategoriler.Items.Clear();
            cmbKategoriler.DataSource = _categoryRepo.GetAll();
            cmbKategoriler.ValueMember = "FoodCategoryId";
            cmbKategoriler.DisplayMember = "Name";

            cmbKategoriler.SelectedIndex = -1;
            cmbKategoriler.SelectedText = "Kategori seçiniz";

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (cmbPorsiyonlar.SelectedIndex == -1 || cmbPorsiyonlar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen porsiyon tipini ve kategoriyi seçiniz!");
            }
            else
            {
                if (int.TryParse(txtPorsiyonMiktari.Text.Trim(), out int porsiyonMiktari))
                {
                    if (int.TryParse(txtKarb.Text.Trim(), out int karb))
                    {
                        if (int.TryParse(txtProtein.Text.Trim(), out int protein))
                        {
                            if (int.TryParse(txtYag.Text.Trim(), out int yag))
                            {
                                try
                                {
                                    _foodRepo.Add(new Food()
                                    {
                                        Name = txtYemekAdi.Text.Trim(),
                                        //PorsiyonMiktarı ekle = porsiyonMiktari,
                                        //PorsiyonTipi ekle = cmbPorsiyonlar.SelectedIndex,
                                        Calories = CalculatorExtensions.KaloriHesapla(karb, protein, yag),
                                        Carbohydrate = karb,
                                        Protein = protein,
                                        Fat = yag,
                                        CategoryId = (int)cmbKategoriler.SelectedValue
                                    });

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
                            else
                            {
                                MessageBox.Show("Lütfen porsiyon miktarını doğru giriniz!");
                                txtYag.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen protein miktarını doğru giriniz!");
                            txtProtein.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen karbonhidrat miktarını doğru giriniz!");
                        txtKarb.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen porsiyon miktarını doğru giriniz!");
                    txtPorsiyonMiktari.Text = string.Empty;
                }

            }
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pbNewFood_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbNewFood.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
