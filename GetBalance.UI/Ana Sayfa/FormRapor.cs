using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
using GetBalance.UI.Extensions;
using GetBalance.UI.Singeltons;

namespace GetBalance.UI
{
	public partial class FormRapor : Form
	{
		GenericRepository<FoodCategory> foodRepository;
		UserManager userManager;
		GenericRepository<Meal> _meal;
		GenericRepository<FoodMeal> _foodMeal;
		GenericRepository<Food> _food;
		GenericRepository<User> _user;
		GenericRepository<UserDetail> _userDetail;


		public FormRapor()
		{
			InitializeComponent();
			foodRepository = new GenericRepository<FoodCategory>();
			userManager = UserManager.Instance;
			_meal = new GenericRepository<Meal>();
			_foodMeal = new GenericRepository<FoodMeal>();
			_food = new GenericRepository<Food>();
			_user = new GenericRepository<User>();
			_userDetail = new GenericRepository<UserDetail>();
		}

		private void FormRapor_Load(object sender, EventArgs e)
		{
			FillComboBox();
			FillCmbKategori();
			ListViewKiyasEdit(listView1);
			ListViewEnCokEdit(listView2);
		}

		private void ListViewEnCokEdit(ListView lsv)
		{
			lsv.View = View.Details;
			lsv.GridLines = true;
			lsv.FullRowSelect = true;
			ColumnHeader[] headers =
			{
				new ColumnHeader() { Name = "Food", Text = "Yemek", Width = lsv.Width/2, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "FoodCount", Text = "Adet", Width = lsv.Width/2, TextAlign = HorizontalAlignment.Left},
			};

			lsv.Columns.AddRange(headers);
		}

		private void ListViewKiyasEdit(ListView lsv)
		{
			lsv.View = View.Details;
			lsv.GridLines = true;
			lsv.FullRowSelect = true;
			ColumnHeader[] headers =
			{
				new ColumnHeader() { Name = "User", Text = "Kullanıcı", Width = lsv.Width/3, TextAlign = HorizontalAlignment.Left},
				new ColumnHeader() { Name = "Food", Text = "Yemek", Width = lsv.Width/3, TextAlign = HorizontalAlignment.Center},
				new ColumnHeader() { Name = "FoodCount", Text = "Yemek Miktarı", Width= lsv.Width/3, TextAlign = HorizontalAlignment.Center},
			};

			lsv.Columns.AddRange(headers);
		}

		void ListviewDoldur(IList<Kiyas> kiyas)
		{
			listView1.Items.Clear();
			foreach (var item in kiyas)
			{
				string[] row = { item.Name, item.FoodName, item.Count.ToString() };
				ListViewItem lvi = new ListViewItem(row);
				listView1.Items.Add(lvi);
			}
		}

		void ListviewDoldur(IList<EnCokTuketilenYemek> enCokTuketilenYemeks)
		{
			listView2.Items.Clear();
			foreach (var item in enCokTuketilenYemeks)
			{
				string[] row = { item.Name, item.Count.ToString() };
				ListViewItem lvi = new ListViewItem(row);
				listView2.Items.Add(lvi);
			}
		}
		void FillCmbKategori()
		{
			cmbxKategori.DataSource = foodRepository.GetAll();
			cmbxKategori.DisplayMember = "Name";
			cmbxKategori.ValueMember = "FoodCategoryId";
		}



		void FillComboBox()
		{
			cmbxOgun.DataSource = Enum.GetValues(typeof(MealType)).Cast<MealType>().Select
				(x => new
				{
					Value = (int)x,
					DisplayName = x.DisplayName()

				}).ToList();
			cmbxOgun.DisplayMember = "DisplayName";
			cmbxOgun.ValueMember = "Value";
			cmbxOgun.SelectedIndex = -1;
			cmbxOgun.SelectedText = "Seçiniz";


			cmbxOgun2.DataSource = Enum.GetValues(typeof(MealType)).Cast<MealType>().Select
				(x => new
				{
					Value = (int)x,
					DisplayName = x.DisplayName()

				}).ToList();
			cmbxOgun2.DisplayMember = "DisplayName";
			cmbxOgun2.ValueMember = "Value";
			cmbxOgun2.SelectedIndex = -1;
			cmbxOgun2.SelectedText = "Seçiniz";


			cmbxKategori.DataSource = foodRepository.GetAll();
			cmbxKategori.DisplayMember = "Name";
			cmbxKategori.ValueMember = "FoodCategoryId";
			cmbxKategori.SelectedIndex = -1;
			cmbxKategori.SelectedText = "Seçiniz";
		}

		private void Kiyasla(object sender, EventArgs e)
		{
			if (cmbxKategori.SelectedIndex >= 0 && cmbxOgun2.SelectedIndex >= 0 && (rbAylik.Checked || rbHaftalik.Checked))
			{
				ListviewDoldur(GetRank());
			}
		}

		private void EnCokTuketilenYemek(object sender, EventArgs e)
		{
			if (cmbxOgun.SelectedIndex >= 0)
				ListviewDoldur(GetMeals((MealType)cmbxOgun.SelectedValue));
		}

		private IList<EnCokTuketilenYemek> GetMeals(MealType mealType)
		{
			IList<Meal> meals = _meal.GetAll();

			IList<FoodMeal> foodMeals = _foodMeal.GetAll();
			foreach (var item in foodMeals)
			{
				item.Food = _food.GetAll().Find(f => f.FoodId == item.FoodId);
			}

			IList<Food> foods = _food.GetAll();

			IList<EnCokTuketilenYemek> filteredMeals = (from fm in foodMeals
														join m in meals on fm.MealId equals m.MealId
														join f in foods on fm.FoodId equals f.FoodId
														where m.MealType == mealType && m.UserId == userManager.CurrentUser.UserId
														group f by f.Name into g
														orderby g.Count() descending
														select new EnCokTuketilenYemek
														{
															Name = g.Key,
															Count = g.Count()
														}).ToList();


			return filteredMeals;
		}



		private IList<Kiyas> GetRank()
		{
			int day = rbAylik.Checked ? 30 : 7;
			IList<User> user = _user.GetAll();
			foreach (var item in user)
			{
				item.UserDetail = _userDetail.GetAll().Find(u => u.UserId == item.UserId);
			}

			IList<Meal> meals = _meal.GetAll();

			IList<FoodMeal> foodMeals = _foodMeal.GetAll();

			IList<Food> foods = _food.GetAll();
			foreach (var item in foods)
			{
				item.FoodCategory = foodRepository.GetAll().Find(f => f.FoodCategoryId == item.CategoryId);
			}

			IList<Kiyas> kiyas = (from fm in foodMeals
								  join m in meals on fm.MealId equals m.MealId
								  join f in foods on fm.FoodId equals f.FoodId
								  join u in user on m.UserId equals u.UserId
								  where m.MealType == (MealType)cmbxOgun2.SelectedValue && m.Date >= DateTime.Now.AddDays(-day) && m.Date <= DateTime.Now && f.FoodCategory.FoodCategoryId == (int)cmbxKategori.SelectedValue
								  group new { f, u } by new { f.Name, u.UserDetail.FirstName, u.UserDetail.LastName } into g
								  orderby g.Count() descending
								  select new Kiyas
								  {
									  Name = g.Key.FirstName + " " + g.Key.LastName,
									  FoodName = g.Key.Name,
									  Count = g.Count()
								  }).ToList();


			return kiyas;
		}


	}

	class EnCokTuketilenYemek
	{
		public string Name { get; set; }
		public int Count { get; set; }
	}

	class Kiyas
	{
		public string Name { get; set; }
		public string FoodName { get; set; }
		public int Count { get; set; }
	}
}
