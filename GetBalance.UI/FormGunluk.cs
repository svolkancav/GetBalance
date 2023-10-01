using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
using GetBalance.UI.Repositories;
using GetBalance.UI.Singeltons;
using System;
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
	//Todo : meal'i öğün ekleme sayfasında oluşturup ekleyeceğiz.daha sonra seçilen yemek öğünle foodmeal tablosuna eklenecek.
	public partial class FormGunluk : Form
	{
		UserManager userManager;

		GenericRepository<Meal> _meal;

		FoodMealRepository _foodMeal;

		GenericRepository<Food> _food;

		FoodMeal foodMeal;

		FoodMeal kahvaltiMeal;

		Meal ogleMeal, aksamMeal, aperatifMeal;

		MonthCalendar monthCalendar;


		bool kahvaltiAcikMi, ogleAcikMi, aksamAcikMi, aperatifAcikMi = false;
		Point pbAddButtonLoc = new Point(5, 5);
		Point tlpVerilerLoc = new Point(473, 3);

		DateTime date;

		public FormGunluk()
		{
			InitializeComponent();
			userManager = UserManager.Instance;

			_meal = new GenericRepository<Meal>();

			monthCalendar = new MonthCalendar();

			_foodMeal = new FoodMealRepository();

			_food = new GenericRepository<Food>();

			foodMeal = new FoodMeal();

			kahvaltiMeal = new FoodMeal();
			ogleMeal = new Meal();
			aksamMeal = new Meal();
			aperatifMeal = new Meal();

			pnlKahveLsv.Visible = pnlOgleLsv.Visible = pnlAksamLsv.Visible = pnlAperatifLsv.Visible = false;


		}

		private void FormGunluk_Load(object sender, EventArgs e)
		{
			#region MonthCalendar
			monthCalendar.Visible = false;
			monthCalendar.Location = new Point(btnLeft.Width + lblTarih.Width / 2 - monthCalendar.Width / 2 - 20, 5);
			monthCalendar.MaxSelectionCount = 1;
			pnlMain.Controls.Add(monthCalendar);
			monthCalendar.DateSelected += MonthCalendar_DateSelected;
			#endregion

			pbAddKahvalti.Parent = btnKahvalti;
			pbAddOgle.Parent = btnOgleYemegi;
			pbAddAksam.Parent = btnAksamYmegi;
			pbAddAperatif.Parent = btnAperatif;

			tlpKahvaltiVeriler.Parent = btnKahvalti;
			tlpOgleVeriler.Parent = btnOgleYemegi;
			tlpAksamVeriler.Parent = btnAksamYmegi;
			tlpAperatifVeriler.Parent = btnAperatif;

			pbAddKahvalti.Location = pbAddButtonLoc;
			pbAddOgle.Location = pbAddButtonLoc;
			pbAddAksam.Location = pbAddButtonLoc;
			pbAddAperatif.Location = pbAddButtonLoc;

			tlpKahvaltiVeriler.Location = tlpVerilerLoc;
			tlpOgleVeriler.Location = tlpVerilerLoc;
			tlpAksamVeriler.Location = tlpVerilerLoc;
			tlpAperatifVeriler.Location = tlpVerilerLoc;

			date = DateTime.Today;
			lblTarih.Text = date.ToShortDateString();




			ListViewEdit(lsvKahvalti);
			ListViewEdit(lsvOgle);
			ListViewEdit(lsvAksam);
			ListViewEdit(lsvAperatif);

			RefreshListView();
		}

		private void MealTotal(ListView listView, out double tCalorie, out double tCarb, out double tProtein, out double tFat)
		{
			Meal meal = new Meal();

			foreach (ListViewItem item in listView.Items)
			{
				FoodMeal fm = (FoodMeal)item.Tag;
				meal.MealFoods.Add(fm);
			}
			tCalorie = Math.Round(meal.TotalCalories, 2);
			tCarb = Math.Round(meal.TotalCarbohydrate);
			tProtein = Math.Round(meal.TotalProtein);
			tFat = Math.Round(meal.TotalFat);
		}

		private void RefreshListView()
		{
			IList<LsvItem> filteredBreakteasts = GetMeals(MealType.Breakfast);
			IList<LsvItem> filteredLunches = GetMeals(MealType.Lunch);
			IList<LsvItem> filteredDinners = GetMeals(MealType.Dinner);
			IList<LsvItem> filteredSnacks = GetMeals(MealType.Snack);



			FillListViewWithFoods(lsvKahvalti, filteredBreakteasts);
			FillListViewWithFoods(lsvOgle, filteredLunches);
			FillListViewWithFoods(lsvAksam, filteredDinners);
			FillListViewWithFoods(lsvAperatif, filteredSnacks);

			MealTotal(lsvKahvalti, out double tCalorie, out double tCarb, out double tProtein, out double tFat);
			lblKahvaltiTopKalori.Text = tCalorie.ToString();
			lblKahvaltiTopKarb.Text = tCarb.ToString();
			lblKahvaltiTopProtein.Text = tProtein.ToString();
			lblKahvaltiTopYag.Text = tFat.ToString() ;

			MealTotal(lsvOgle, out tCalorie, out tCarb, out tProtein, out tFat);
			lblOgleTopKalori.Text = tCalorie.ToString()  ;
			lblOgleTopKarb.Text = tCarb.ToString() ;
			lblOgleTopProtein.Text = tProtein.ToString() ;
			lblOgleTopYag.Text = tFat.ToString() ;

			MealTotal(lsvAksam, out tCalorie, out tCarb, out tProtein, out tFat);
			lblAksamTopKalori.Text = tCalorie.ToString() ;
			lblAksamTopKarb.Text = tCarb.ToString() ;
			lblAksamTopProtein.Text = tProtein.ToString() ;
			lblAksamTopYag.Text = tFat.ToString() ;

			MealTotal(lsvAperatif, out tCalorie, out tCarb, out tProtein, out tFat);
			lblAperatifTopKalori.Text = tCalorie.ToString() ;
			lblAperatifTopKarb.Text = tCarb.ToString() ;
			lblAperatifTopProtein.Text = tProtein.ToString() ;
			lblAperatifTopYag.Text = tFat.ToString() ;

			lblSuankiKalori.Text = (Convert.ToDouble(lblKahvaltiTopKalori.Text) + Convert.ToDouble(lblOgleTopKalori.Text) + Convert.ToDouble(lblAksamTopKalori.Text) + Convert.ToDouble(lblAperatifTopKalori.Text)).ToString();
			lblSuankiKarb.Text = (Convert.ToDouble(lblKahvaltiTopKarb.Text) + Convert.ToDouble(lblOgleTopKarb.Text) + Convert.ToDouble(lblAksamTopKarb.Text) + Convert.ToDouble(lblAperatifTopKarb.Text)).ToString();
			lblSuankiProtein.Text = (Convert.ToDouble(lblKahvaltiTopProtein.Text) + Convert.ToDouble(lblOgleTopProtein.Text) + Convert.ToDouble(lblAksamTopProtein.Text) + Convert.ToDouble(lblAperatifTopProtein.Text)).ToString();
			lblSuankiYag.Text = (Convert.ToDouble(lblKahvaltiTopYag.Text) + Convert.ToDouble(lblOgleTopYag.Text) + Convert.ToDouble(lblAksamTopYag.Text) + Convert.ToDouble(lblAperatifTopYag.Text)).ToString();

		}

		private IList<LsvItem> GetMeals(MealType mealType)
		{
			IList<Meal> meals = _meal.GetAll();

			IList<FoodMeal> foodMeals = _foodMeal.GetAll();
			foreach (var item in foodMeals)
			{
				item.Food = _food.GetAll().Find(f => f.FoodId == item.FoodId);
			}

			IList<Food> foods = _food.GetAll();

			IList<LsvItem> filteredMeals = foodMeals
				.Join(meals, fm => fm.MealId, m => m.MealId, (fm, m) => new { fm, m })
				.Where(joined => joined.m.UserId == userManager.CurrentUser.UserId &&
				joined.m.MealType == mealType && joined.m.Date == Convert.ToDateTime(lblTarih.Text)
				)
				.Select(joined => new LsvItem
				{
					FoodMeal = joined.fm,
					Food = joined.fm.Food,
					Name = joined.fm.Food.Name,
					Amount = joined.fm.FoodAmount,
					TotalCalorie = joined.fm.TotalCalori,
					TotalCarb = joined.fm.TotalCarb,
					TotalProtein = joined.fm.TotalProtein,
					TotalFat = joined.fm.TotalFat
				}).ToList();
			return filteredMeals;
		}

		#region Öğünlerin Açılıp Kapanması
		private void btnKahvalti_Click(object sender, EventArgs e)
		{
			pnlKahveLsv.Visible = !kahvaltiAcikMi;
			kahvaltiAcikMi = !kahvaltiAcikMi;
			RefreshListView();
		}

		private void btnOgleYemegi_Click(object sender, EventArgs e)
		{
			pnlOgleLsv.Visible = !ogleAcikMi;
			ogleAcikMi = !ogleAcikMi;
			RefreshListView();
		}

		private void btnAksamYmegi_Click(object sender, EventArgs e)
		{
			pnlAksamLsv.Visible = !aksamAcikMi;
			aksamAcikMi = !aksamAcikMi;
			RefreshListView();
		}

		private void btnAperatif_Click(object sender, EventArgs e)
		{
			pnlAperatifLsv.Visible = !aperatifAcikMi;
			aperatifAcikMi = !aperatifAcikMi;
			RefreshListView();
		}
		#endregion

		private void FillListViewWithFoods(ListView listView, IList<LsvItem> lsvItem)
		{
			listView.Items.Clear();

			foreach (var item in lsvItem)
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = item.Name;
				listViewItem.SubItems.Add(item.Amount.ToString());
				listViewItem.SubItems.Add(item.TotalCalorie.ToString());
				listViewItem.SubItems.Add(item.TotalCarb.ToString());
				listViewItem.SubItems.Add(item.TotalProtein.ToString());
				listViewItem.SubItems.Add(item.TotalFat.ToString());

				listViewItem.Tag = item.FoodMeal;

				listView.Items.Add(listViewItem);
			}
		}

		private void ListViewEdit(ListView lsv)
		{
			lsv.View = View.Details;
			lsv.GridLines = true;
			lsv.FullRowSelect = true;

			ColumnHeader[] headers =
			{
				new ColumnHeader() { Name = "Food", Text = "Yemek", Width = lsv.Width-500, TextAlign = HorizontalAlignment.Left},
				new ColumnHeader() { Name = "Portion", Text = "Porsiyon Miktarı", Width = 100, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "Calorie", Text = "Kalori", Width = 100, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "Carb", Text = "Karbonhidrat", Width = 100, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "Protein", Text = "Protein", Width = 100, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "Fat", Text = "Yağ", Width = 100, TextAlign = HorizontalAlignment.Center}
			};

			lsv.Columns.AddRange(headers);

		}

		private void TsmClick(object sender, EventArgs e)
		{
			ToolStripMenuItem tsmItem = (ToolStripMenuItem)sender;
			string tsmName = tsmItem.Name;

			if (tsmName == "tsmDuzenle")
			{
				if (lsvKahvalti.SelectedItems.Count > 0)
					TsmUpdateClicked(lsvKahvalti);
				else if (lsvOgle.SelectedItems.Count > 0)
					TsmUpdateClicked(lsvOgle);
				else if (lsvAksam.SelectedItems.Count > 0)
					TsmUpdateClicked(lsvAksam);
				else if (lsvAperatif.SelectedItems.Count > 0)
					TsmUpdateClicked(lsvAperatif);
			}
			else if (tsmName == "tsmKaldir")
			{
				if (lsvKahvalti.SelectedItems.Count > 0)
					TsmDeleteClicked(lsvKahvalti);
				else if (lsvOgle.SelectedItems.Count > 0)
					TsmDeleteClicked(lsvOgle);
				else if (lsvAksam.SelectedItems.Count > 0)
					TsmDeleteClicked(lsvAksam);
				else if (lsvAperatif.SelectedItems.Count > 0)
					TsmDeleteClicked(lsvAperatif);
			}
		}

		private void TsmDeleteClicked(ListView lsv)
		{

			if (lsv.SelectedItems.Count <= 0) return;

			DialogResult dialogResult = MessageBox.Show("Yemeği öğünden kaldırmak istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult != DialogResult.Yes) return;

			FoodMeal foodMeal = (FoodMeal)lsv.SelectedItems[0].Tag;

			_foodMeal.Delete(foodMeal);

			RefreshListView();
		}

		private void TsmUpdateClicked(ListView lsv)
		{
			int count = lsv.SelectedItems.Count;

			if (count <= 0) return;


			FormAddFood formUpdateFood = new FormAddFood((FoodMeal)lsv.SelectedItems[0].Tag);
			formUpdateFood.Show();
		}

		#region ListViewAçılıpKapanması
		private void lsv_MouseClick(object sender, MouseEventArgs e)
		{
			ListView listView = sender as ListView;

			switch (listView.Name)
			{
				case "lsvKahvalti": LsvTiklandi(lsvKahvalti, e); break;
				case "lsvOgle": LsvTiklandi(lsvOgle, e); break;
				case "lsvAksam": LsvTiklandi(lsvAksam, e); break;
				case "lsvAperatif": LsvTiklandi(lsvAperatif, e); break;
			}
		}

		private void LsvTiklandi(ListView lsv, MouseEventArgs e)
		{
			MouseButtons button = e.Button;
			if (button != MouseButtons.Right) return;

			ListViewItem lvi = lsv.FocusedItem;
			bool isBound = lvi.Bounds.Contains(e.Location);

			if (lvi == null || !isBound) return;

			cmsSagTik.Show(Cursor.Position);
		}

		#endregion
		private void pbAdd_Clicked(object sender, EventArgs e)
		{

			PictureBox pbAdd = sender as PictureBox;
			switch (pbAdd.Name)
			{
				case "pbAddKahvalti": OpenFormYemekEkleme(MealType.Breakfast, Convert.ToDateTime(lblTarih.Text)); break;
				case "pbAddOgle": OpenFormYemekEkleme(MealType.Lunch, Convert.ToDateTime(lblTarih.Text)); break;
				case "pbAddAksam": OpenFormYemekEkleme(MealType.Dinner, Convert.ToDateTime(lblTarih.Text)); break;
				case "pbAddAperatif": OpenFormYemekEkleme(MealType.Snack, Convert.ToDateTime(lblTarih.Text)); break;

			}
		}

		private void OpenFormYemekEkleme(MealType mealtype, DateTime dateTime)
		{
			FormAddFood formAddFood = new FormAddFood(mealtype, dateTime);
			formAddFood.ShowDialog();
		}

		private void btnRight_Click(object sender, EventArgs e)
		{
			date = date.AddDays(1);
			lblTarih.Text = date.ToShortDateString();
			RefreshListView();
		}

		private void btnLeft_Click(object sender, EventArgs e)
		{
			date = date.AddDays(-1);
			lblTarih.Text = date.ToShortDateString();
			RefreshListView();
		}

		private void lblTarih_DoubleClick(object sender, EventArgs e)
		{
			monthCalendar.Visible = true;
			monthCalendar.BringToFront();
		}

		private void MonthCalendar_DateSelected(object? sender, DateRangeEventArgs e)
		{
			date = monthCalendar.SelectionStart;
			lblTarih.Text = date.ToShortDateString();
			monthCalendar.Visible = false;
		}


	}
	class LsvItem
	{
		public FoodMeal FoodMeal { get; set; }
		public Food Food { get; set; }
		public string Name { get; set; }
		public int Amount { get; set; }
		public double TotalCalorie { get; set; }
		public double TotalCarb { get; set; }
		public double TotalProtein { get; set; }
		public double TotalFat { get; set; }

	}

}
