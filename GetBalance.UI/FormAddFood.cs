using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using GetBalance.UI.Repositories;
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
    public partial class FormAddFood : Form
    {
        FoodRepository _foodRepo;
        GenericRepository<FoodCategory> _categoryRepo;


        public FormAddFood()
        {
            InitializeComponent();
            _foodRepo = new FoodRepository();
            _categoryRepo = new GenericRepository<FoodCategory>();
        }

        private void FormAddFood_Load(object sender, EventArgs e)
        {
            FillComboBox();
            ListViewEdit();
            FillListViewWithFoods(_foodRepo.GetAll());

        }
        private void FillComboBox()
        {
            cmbKategoriler.Items.Clear();
            cmbKategoriler.DataSource = _categoryRepo.GetAll();
            cmbKategoriler.ValueMember = "FoodCategoryId";
            cmbKategoriler.DisplayMember = "Name";

            cmbKategoriler.SelectedIndex = -1;
            cmbKategoriler.SelectedText = "Kategori";

        }

        private void ListViewEdit()
        {
            lsvFoods.View = View.Details;
            lsvFoods.GridLines = true;
            lsvFoods.FullRowSelect = true;

            ColumnHeader[] headers =
            {
                new ColumnHeader() { Name = "Food", Text = "Yemek", Width = lsvFoods.Width-250, TextAlign = HorizontalAlignment.Left},
                new ColumnHeader() { Name = "Portion", Text = "Posiyon Miktarı", Width = 50, TextAlign = HorizontalAlignment.Center},
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
                //listViewItem.SubItems.Add(food.TotalQuantity.ToString());
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
            //TODO: Seçili öğüne yemek ekle
        }
        private void pbKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
