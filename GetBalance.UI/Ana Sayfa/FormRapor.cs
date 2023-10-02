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
using GetBalance.UI.Queries;
using GetBalance.UI.Singeltons;
using static GetBalance.UI.Queries.DBQueries;

namespace GetBalance.UI
{
	public partial class FormRapor : Form
	{
		GenericRepository<FoodCategory> foodRepository;
		UserManager userManager;
		DBQueries reportQueries;


		public FormRapor()
		{
			InitializeComponent();
			foodRepository = new GenericRepository<FoodCategory>();
			userManager = UserManager.Instance;
			reportQueries = new DBQueries();
		}

		private void FormRapor_Load(object sender, EventArgs e)
		{
			FillComboBox();
			ListViewKiyasEdit(listView1);
			ListViewEnCokEdit(listView2);
			MessageBox.Show("Seçimler yapıldıktan sonra sonuçlar listelenecektir.");
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
			cmbxOgun.SelectedText = "Lütfen Seçim yapınız";


			cmbxOgun2.DataSource = Enum.GetValues(typeof(MealType)).Cast<MealType>().Select
				(x => new
				{
					Value = (int)x,
					DisplayName = x.DisplayName()

				}).ToList();
			cmbxOgun2.DisplayMember = "DisplayName";
			cmbxOgun2.ValueMember = "Value";
			cmbxOgun2.SelectedIndex = -1;
			cmbxOgun2.SelectedText = "Lütfen Seçim yapınız";


			cmbxKategori.DataSource = foodRepository.GetAll();
			cmbxKategori.DisplayMember = "Name";
			cmbxKategori.ValueMember = "FoodCategoryId";
			cmbxKategori.SelectedIndex = -1;
			cmbxKategori.SelectedText = "Lütfen Seçim yapınız";
		}

		private void Kiyasla(object sender, EventArgs e)
		{
			if (cmbxKategori.SelectedIndex >= 0 && cmbxOgun2.SelectedIndex >= 0 && (rbAylik.Checked || rbHaftalik.Checked))
			{
				ListviewDoldur(reportQueries.GetRank((MealType)cmbxOgun2.SelectedValue, (int)cmbxKategori.SelectedValue, rbAylik.Checked));
			}
		}

		private void EnCokTuketilenYemek(object sender, EventArgs e)
		{
			if (cmbxOgun.SelectedIndex >= 0)
				ListviewDoldur(reportQueries.EnCokTuketilenYemekListele((MealType)cmbxOgun.SelectedValue, userManager.CurrentUser.UserId));
		}

	}

}
