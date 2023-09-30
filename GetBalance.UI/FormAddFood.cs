using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
using GetBalance.UI.Repositories;
using GetBalance.UI.Singeltons;
using System;
using System.CodeDom;
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
    public partial class FormAddFood : Form
    {
        UserManager userManager;
        FoodRepository _foodRepo;
        GenericRepository<FoodCategory> _categoryRepo;
        GenericRepository<Portion> _portionRepo;

        Meal seciliMeal;
        Food seciliYemek;
        Portion yeniPorsiyon;
        public FormAddFood(Meal meal)
        {
            InitializeComponent();
            userManager = UserManager.Instance;
            _foodRepo = new FoodRepository();
            _categoryRepo = new GenericRepository<FoodCategory>();
            _portionRepo = new GenericRepository<Portion>();
            seciliMeal = meal;

        }

        private void FormAddFood_Load(object sender, EventArgs e)
        {
            FillComboBoxKategoriler();
            FillComboBoxPorsiyonlar();
            ListViewEdit();

            FillListViewWithFoods(_foodRepo.GetAll());

        }
        private void FillComboBoxKategoriler()
        {
            cmbKategoriler.Items.Clear();
            cmbKategoriler.DataSource = _categoryRepo.GetAll();
            cmbKategoriler.ValueMember = "FoodCategoryId";
            cmbKategoriler.DisplayMember = "Name";

            cmbKategoriler.SelectedIndex = -1;
            cmbKategoriler.SelectedText = "Kategori";

        }

        private void FillComboBoxPorsiyonlar()
        {
            cmbPorsiyonlar.Items.Clear();
            cmbPorsiyonlar.DataSource = Enum.GetValues(typeof(PortionName));

            cmbPorsiyonlar.SelectedIndex = -1;
            cmbPorsiyonlar.SelectedText = "Seçiniz";

        }

        private void ListViewEdit()
        {
            lsvFoods.View = View.Details;
            lsvFoods.GridLines = true;
            lsvFoods.FullRowSelect = true;

            ColumnHeader[] headers =
            {
                new ColumnHeader() { Name = "Food", Text = "Yemek", Width = lsvFoods.Width-250, TextAlign = HorizontalAlignment.Left},
                //new ColumnHeader() { Name = "Portion", Text = "Posiyon Miktarı", Width = 50, TextAlign = HorizontalAlignment.Center},
                new ColumnHeader() { Name = "Calorie", Text = "Kalori", Width = 50, TextAlign = HorizontalAlignment.Center},
                new ColumnHeader() { Name = "Carb", Text = "Karbonhidrat", Width = 50, TextAlign = HorizontalAlignment.Center},
                new ColumnHeader() { Name = "Protein", Text = "Protein", Width = 50, TextAlign = HorizontalAlignment.Center},
                new ColumnHeader() { Name = "Fat", Text = "Yağ", Width = 50, TextAlign = HorizontalAlignment.Center}
            };

            lsvFoods.Columns.AddRange(headers);
        }

        private void FillListViewWithFoods(List<Food> foods)
        {
            lsvFoods.Items.Clear();

            foreach (Food food in foods)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = food.Name;
                //listViewItem.SubItems.Add("100 gr");
                listViewItem.SubItems.Add(food.Calories.ToString());
                listViewItem.SubItems.Add(food.Carbohydrate.ToString());
                listViewItem.SubItems.Add(food.Protein.ToString());
                listViewItem.SubItems.Add(food.Fat.ToString());

                listViewItem.Tag = food;

                lsvFoods.Items.Add(listViewItem);
            }
        }

        private void txtYemekAra_TextChanged(object sender, EventArgs e)
        {
            string foodName = txtYemekAra.Text.Trim();
            FillListViewWithFoods(_foodRepo.GetByFilterName(foodName));
        }

        private void btnYeniYemekEkle_Click(object sender, EventArgs e)
        {
            FormAddNewFoodToDb formAddNewFoodToDb = new FormAddNewFoodToDb();
            formAddNewFoodToDb.ShowDialog();
        }

        private void btnOguneEkle_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtPosiyonMiktari.Text.Trim(), out int porsiyonMiktari))
            {
                seciliYemek = lsvFoods.SelectedItems[0].Tag as Food;

                //yeniPorsiyon = new Portion()
                //{
                //    FoodId = seciliYemek.FoodId,
                //    Quantity = porsiyonMiktari,
                //    PortionName = cm

                //}
                seciliMeal.Foods.Add(seciliYemek);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir porsiyon miktarı giriniz!");
                txtPosiyonMiktari.Text = string.Empty;
            }
        }
        private void pbKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Food> filtreliYemekler = (List<Food>)_foodRepo.GetAll().Where(x => x.CategoryId == (int)cmbKategoriler.SelectedValue);
            FillListViewWithFoods(filtreliYemekler);
        }
    }
}
