using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
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

    public partial class FormGunluk : Form
    {
        UserManager userManager;

        GenericRepository<Meal> _meal;

        GenericRepository<FoodMeal> _foodMeal;

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

            _foodMeal = new GenericRepository<FoodMeal>();

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

        private void RefreshListView()
        {

            //kahvaltiMeal = _meal.GetAll().Find(us => us.UserId == userManager.CurrentUser.UserId && us.MealType == DATA.Enums.MealType.Breakfast && us.Date == Convert.ToDateTime(lblTarih.Text));

            //kahvaltiMeal = _foodMeal.GetAll()

            ogleMeal = _meal.GetAll().Find(us => us.UserId == userManager.CurrentUser.UserId && us.MealType == DATA.Enums.MealType.Lunch && us.Date == Convert.ToDateTime(lblTarih.Text));
            aksamMeal = _meal.GetAll().Find(us => us.UserId == userManager.CurrentUser.UserId && us.MealType == DATA.Enums.MealType.Dinner && us.Date == Convert.ToDateTime(lblTarih.Text));
            aperatifMeal = _meal.GetAll().Find(us => us.UserId == userManager.CurrentUser.UserId && us.MealType == DATA.Enums.MealType.Snack && us.Date == Convert.ToDateTime(lblTarih.Text));

            //if (kahvaltiMeal == null)
            //{
            //    kahvaltiMeal = new Meal()
            //    {
            //        MealType = MealType.Breakfast,
            //        Date = Convert.ToDateTime(lblTarih.Text),
            //        UserId = userManager.CurrentUser.UserId,
            //        //Name = $"{userManager.CurrentUser.UserId} + {Convert.ToDateTime(lblTarih.Text)} + {MealType.Breakfast} "
            //        Name = "asd"
            //    };
            //    _meal.Add(kahvaltiMeal);
            //    foodMeal.Meal = kahvaltiMeal;
            //}
            //foodMeal.Meal = kahvaltiMeal;
            //FillListViewWithFoods(lsvKahvalti, kahvaltiMeal);

            if (ogleMeal == null)
            {
                ogleMeal = new Meal()
                {
                    MealType = MealType.Lunch,
                    Date = Convert.ToDateTime(lblTarih.Text),
                    UserId = userManager.CurrentUser.UserId,
                    //Name = $"{userManager.CurrentUser.UserId} + {Convert.ToDateTime(lblTarih.Text)} + {MealType.Lunch} "
                    Name = "asd"
                };
                _meal.Add(ogleMeal);
                
            }
            FillListViewWithFoods(lsvOgle, ogleMeal);

            if (aksamMeal == null)
            {
                aksamMeal = new Meal()
                {
                    MealType = MealType.Dinner,
                    Date = Convert.ToDateTime(lblTarih.Text),
                    UserId = userManager.CurrentUser.UserId,
                    //Name = $"{userManager.CurrentUser.UserId} + {Convert.ToDateTime(lblTarih.Text)} + {MealType.Dinner} "
                    Name = "asd"
                };
                _meal.Add(aksamMeal);
            }
            FillListViewWithFoods(lsvAksam, aksamMeal);

            if (aperatifMeal == null)
            {
                aperatifMeal = new Meal()
                {
                    MealType = MealType.Snack,
                    Date = Convert.ToDateTime(lblTarih.Text),
                    UserId = userManager.CurrentUser.UserId,
                    //Name = $"{userManager.CurrentUser.UserId} + {Convert.ToDateTime(lblTarih.Text)} + {MealType.Snack} "
                    Name = "asd"
                };
                _meal.Add(aperatifMeal);
            }
            FillListViewWithFoods(lsvAperatif, aperatifMeal);
        }

        #region Öğünlerin Açılıp Kapanması
        private void btnKahvalti_Click(object sender, EventArgs e)
        {
            pnlKahveLsv.Visible = !kahvaltiAcikMi;
            kahvaltiAcikMi = !kahvaltiAcikMi;
        }

        private void btnOgleYemegi_Click(object sender, EventArgs e)
        {
            pnlOgleLsv.Visible = !ogleAcikMi;
            ogleAcikMi = !ogleAcikMi;
        }

        private void btnAksamYmegi_Click(object sender, EventArgs e)
        {
            pnlAksamLsv.Visible = !aksamAcikMi;
            aksamAcikMi = !aksamAcikMi;
        }

        private void btnAperatif_Click(object sender, EventArgs e)
        {
            pnlAperatifLsv.Visible = !aperatifAcikMi;
            aperatifAcikMi = !aperatifAcikMi;
        }
        #endregion

        private void FillListViewWithFoods(ListView listView, Meal meal)
        {
            listView.Items.Clear();

            List<FoodMeal> foodMealList = _foodMeal.GetAll();
            List<Food> foodList = _food.GetAll();
            

            List<FoodMeal> mealFoods = foodMealList.FindAll(x=>x.MealId == meal.MealId);
            List<int> foodIdList = mealFoods.Select(fm => fm.FoodId).ToList();

            List<Food> filteredFoods = foodList.Where(food => foodIdList.Contains(food.FoodId)).ToList();

            //Foods list lazım
            // 

            foreach (Food food in filteredFoods)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = food.Name;
                listViewItem.SubItems.Add(_foodMeal.GetAll().Find(x => x.FoodId == food.FoodId).FoodAmount.ToString());
                listViewItem.SubItems.Add(_foodMeal.GetAll().Find(x=>x.FoodId == food.FoodId).TotalCalori.ToString());
                listViewItem.SubItems.Add(food.Carbohydrate.ToString());
                listViewItem.SubItems.Add(food.Protein.ToString());
                listViewItem.SubItems.Add(food.Fat.ToString());

                listViewItem.Tag = food;

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

            if (tsmName == "tsmUpdate")
            {
                if (lsvKahvalti.ClientRectangle.Contains(Cursor.Position))
                    TsmUpdateClicked(lsvKahvalti);
                else if (lsvOgle.ClientRectangle.Contains(Cursor.Position))
                    TsmUpdateClicked(lsvOgle);
                else if (lsvAksam.ClientRectangle.Contains(Cursor.Position))
                    TsmUpdateClicked(lsvAksam);
                else if (lsvAperatif.ClientRectangle.Contains(Cursor.Position))
                    TsmUpdateClicked(lsvAperatif);
            }
            else if (tsmName == "tsmDelete")
            {
                if (lsvKahvalti.ClientRectangle.Contains(Cursor.Position))
                    TsmDeleteClicked(lsvKahvalti);
                else if (lsvOgle.ClientRectangle.Contains(Cursor.Position))
                    TsmDeleteClicked(lsvOgle);
                else if (lsvAksam.ClientRectangle.Contains(Cursor.Position))
                    TsmDeleteClicked(lsvAksam);
                else if (lsvAperatif.ClientRectangle.Contains(Cursor.Position))
                    TsmDeleteClicked(lsvAperatif);
            }
        }

        private void TsmDeleteClicked(ListView lsv)
        {

            if (lsv.SelectedItems.Count <= 0) return;

            DialogResult dialogResult = MessageBox.Show("Yemeği öğünden kaldırmak istediğinizden emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;

            //TODO : Yemeği öğünden sil

        }

        private void TsmUpdateClicked(ListView lsv)
        {
            int count = lsv.SelectedItems.Count;

            if (count <= 0) return;

            //TODO : Yemeği güncelle
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
                //case "pbAddKahvalti": OpenFormYemekEkleme(kahvaltiMeal); break;
                case "pbAddOgle": OpenFormYemekEkleme(ogleMeal); break;
                case "pbAddAksam": OpenFormYemekEkleme(aksamMeal); break;
                case "pbAddAperatif": OpenFormYemekEkleme(aperatifMeal); break;

            }
        }

        private void OpenFormYemekEkleme(Meal meal)
        {
            FormAddFood formAddFood = new FormAddFood(meal);
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

}
