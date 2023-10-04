using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA.Entities;
using GetBalance.DATA.Enums;
using GetBalance.UI.Events;
using GetBalance.UI.Extensions;
using GetBalance.UI.Properties;
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
using static GetBalance.UI.FormHomePage;

namespace GetBalance.UI
{
	public partial class FormAddFood : Form
	{
		UserManager userManager;
		FoodRepository _foodRepo;
		FoodMealRepository _foodMealRepo;
		GenericRepository<FoodCategory> _foodCategoryRepo;
		GenericRepository<Meal> _mealRepo;

		MealType seciliMealType;
		Food seciliYemek;
		FoodMeal _foodMeal;
		DateTime dateTime1;
		bool cmbCategoryFlag = false;

		List<Food> foods;

		public FormAddFood(MealType mealType, DateTime dateTime)
		{
			InitializeForm();

			seciliMealType = mealType;
			dateTime1 = dateTime;
		}

		private void InitializeForm()
		{
			InitializeComponent();

			userManager = UserManager.Instance;
			_foodRepo = new FoodRepository();
			_foodMealRepo = new FoodMealRepository();
			_foodCategoryRepo = new GenericRepository<FoodCategory>();
			_mealRepo = new GenericRepository<Meal>();
			foods = new List<Food>();
		}

		public FormAddFood()
		{
			InitializeComponent();
		}
		public FormAddFood(FoodMeal foodMeal)
		{
			InitializeForm();
			_foodMeal = foodMeal;


			if (_foodMeal != null)
			{
				FillListViewWithFoods(_foodRepo.GetAll().Where(x => x.FoodId == _foodMeal.FoodId).ToList());
				lsvFoods.Items[0].Selected = true;
				lsvFoods.Select();
				lsvFoods.Focus();
				txtPosiyonMiktari.Text = _foodMeal.FoodAmount.ToString();
				cmbKategoriler.SelectedValue = _foodRepo.GetAll().Where(x => x.FoodId == _foodMeal.FoodId).ToList()[0].CategoryId;
				txtYemekAra.Text = _foodRepo.GetAll().Where(x => x.FoodId == _foodMeal.FoodId).ToList()[0].Name;
				btnOguneEkle.Text = "Güncelle";
				btnYeniYemekEkle.Visible = false;
			}
		}

		private void FormAddFood_Load(object sender, EventArgs e)
		{
			ListViewEdit();

			FillComboBoxKategoriler(_foodMeal);
			if (_foodMeal != null) return;
			FillListViewWithFoods(_foodRepo.GetAll());
		}


		private void FillComboBoxKategoriler(FoodMeal foodMeal)
		{
			cmbKategoriler.Items.Clear();

			List<FoodCategory> categories = _foodCategoryRepo.GetAll();

			cmbKategoriler.DataSource = categories;
			cmbKategoriler.ValueMember = "FoodCategoryId";
			cmbKategoriler.DisplayMember = "Name";
			if (foodMeal != null) return;

			cmbKategoriler.SelectedIndex = -1;
			cmbKategoriler.SelectedText = "Kategori";
			cmbCategoryFlag = true;

		}

		private void FillLblPorsiyonlar()
		{
			lblPorsiyonDetayi.Text = seciliYemek.PortionName.DisplayName();
		}

		private void ListViewEdit()
		{
			lsvFoods.View = View.Details;
			lsvFoods.GridLines = true;
			lsvFoods.FullRowSelect = true;

			int width = lsvFoods.Width / 6;


			ColumnHeader[] headers =
			{
				new ColumnHeader() { Name = "Food", Text = "Yemek", Width = width*2, TextAlign = HorizontalAlignment.Left},
				new ColumnHeader() { Name = "Calorie", Text = "Kalori", Width = width, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "Carb", Text = "Karbonhidrat", Width = width, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "Protein", Text = "Protein", Width = width, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "Fat", Text = "Yağ", Width = width, TextAlign = HorizontalAlignment.Center}
			};

			lsvFoods.Columns.AddRange(headers);
		}

		private void FillListViewWithFoods(List<Food> foods)
		{
			lsvFoods.Items.Clear();

			ImageList imageList = new ImageList();
			imageList.ImageSize = new Size(60, 60);

			foreach (Food food in foods)
			{
				Bitmap bmp = new Bitmap(Resources.foodicon);
				if (food.Picture != null)
				{
					bmp = new Bitmap(food.Picture);
				}


				imageList.Images.Add(food.FoodId.ToString(), bmp);

				ListViewItem listViewItem = new ListViewItem();
				listViewItem.ImageKey = food.FoodId.ToString();
				listViewItem.Text = food.Name;
				listViewItem.SubItems.Add(food.Calories.ToString());
				listViewItem.SubItems.Add(food.Carbohydrate.ToString());
				listViewItem.SubItems.Add(food.Protein.ToString());
				listViewItem.SubItems.Add(food.Fat.ToString());

				listViewItem.Tag = food;

				lsvFoods.Items.Add(listViewItem);
			}
			lsvFoods.SmallImageList = imageList;
		}

		private void txtYemekAra_TextChanged(object sender, EventArgs e)
		{
			FilterFoods();
		}

		private void FilterFoods()
		{
			string foodName = txtYemekAra.Text.Trim();
			if (cmbKategoriler.SelectedIndex == -1)
			{
				FillListViewWithFoods(_foodRepo.GetByFilterName(foodName));
			}
			else if (cmbCategoryFlag == true)
			{
				FillListViewWithFoods(_foodRepo.GetByFilterName(foodName).Where(f => f.CategoryId == (int)cmbKategoriler.SelectedValue).ToList());
			}
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
				Meal meal = new Meal() { MealType = seciliMealType, Name = "deneme", UserId = userManager.CurrentUser.UserId, Date = dateTime1 };

				if (_foodMeal != null)
				{
					meal = _mealRepo.GetById(_foodMeal.MealId);
					_foodMeal.FoodAmount = porsiyonMiktari;
					_foodMeal.Food = seciliYemek;
					_foodMealRepo.Update(_foodMeal);
					FormEventService.Instance.OnNewItemAdded();
					this.Close();
				}
				else
				{
					_mealRepo.Add(meal);
					FoodMeal newfoodMeal = new FoodMeal() { FoodId = seciliYemek.FoodId, MealId = meal.MealId, FoodAmount = porsiyonMiktari };
					_foodMealRepo.Add(newfoodMeal);
					ClearFields();
				}

			}
			else
			{
				MessageBox.Show("Lütfen geçerli bir porsiyon miktarı giriniz!");
				txtPosiyonMiktari.Text = string.Empty;
			}
		}

		private void ClearFields()
		{
			txtPosiyonMiktari.Text = string.Empty;
			txtYemekAra.Text = string.Empty;
			cmbKategoriler.SelectedIndex = -1;
			lblPorsiyonDetayi.Text = string.Empty;
			FillListViewWithFoods(_foodRepo.GetAll());
		}

		private void pbKapat_Click(object sender, EventArgs e)
		{
			this.Close();
			FormEventService.Instance.OnNewItemAdded();
		}

		private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
		{
			FilterFoods();
		}


		private void lsvFoods_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lsvFoods.SelectedItems.Count == 0)
			{
				btnOguneEkle.Enabled = false;
				return;
			};
			btnOguneEkle.Enabled = true;
			seciliYemek = lsvFoods.SelectedItems[0].Tag as Food;

			FillLblPorsiyonlar();

		}

		private void cmbKategoriler_MouseUp(object sender, MouseEventArgs e)
		{
		}
	}
}
