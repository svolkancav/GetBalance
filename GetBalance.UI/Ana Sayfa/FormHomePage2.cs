using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DAL;
using GetBalance.DATA.Entities;
using GetBalance.DATA.Enums;
using GetBalance.UI.Events;
using GetBalance.UI.Extensions;
using GetBalance.UI.Queries;
using GetBalance.UI.Singeltons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetBalance.UI
{

    public partial class FormHomePage2 : Form

    {

        Form formDuzenle, formHedef;
        public Point downPoint = Point.Empty;

        UserDetail _userDetail;
        UserManager userManager;
        DBQueries dBQueries;


        public FormHomePage2()
        {
            InitializeComponent();
            userManager = UserManager.Instance;
            dBQueries = new DBQueries();


            FormEventService.Instance.UserDetailUpdated += FillLabel;
            FormEventService.Instance.UserTagetUpdated += FillLabel;
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            formDuzenle = new FormDuzenle() { TopLevel = false, TopMost = true };
            if (formHedef != null)
                formHedef.Hide();
            pnlYanPanel.Controls.Add(formDuzenle);
            formDuzenle.Show();
            
        }

        private void FormHomePage2_Load(object sender, EventArgs e)
        {

            #region Database e user girilince açılacak.
            _userDetail = userManager.CurrentUser.UserDetail;

            ClearLabels();

            if (_userDetail != null)
                FillLabel();


            #endregion

        }

        private void FillLabel()
        {
            int boy = Convert.ToInt32(_userDetail.Height);
            int kilo = Convert.ToInt32(_userDetail.CurrentWeight);
            int neckCircum = Convert.ToInt32(_userDetail.NeckCircumference);
            int waistCircum = Convert.ToInt32(_userDetail.WaistCircumference);
            int hipCircum = Convert.ToInt32(_userDetail.HipCircumference);
            Gender gender = _userDetail.Gender;
            string cinsiyet = gender.ToString();
            DateTime dateTime = _userDetail.BirthDate;
            int yas = DateTime.Now.Year - dateTime.Year;
            ActivityLevel activity = _userDetail.ActivityLevel;
            TrainingLevel training = _userDetail.TrainingLevel;


            lblGuncelVKI.Text = CalculatorExtensions.VKİHesapla(kilo, boy).ToString();
            lblGuncelBMH.Text = CalculatorExtensions.BMRHesapla(boy, kilo, yas, cinsiyet).ToString() + " Kalori / Gün";
            lblGuncelVYO.Text = CalculatorExtensions.VücutYağOraniHesapla(waistCircum, neckCircum, hipCircum, boy, cinsiyet).ToString();
            lblGuncelIdealKilo.Text = CalculatorExtensions.IdealKiloHesapla(boy, cinsiyet).ToString() + " kg";
            lblGuncelGKI.Text = CalculatorExtensions.GunlukKaloriIhtiyaci(boy, kilo, yas, activity, cinsiyet).ToString() + " Kalori / Gün";
            lblGuncelGSI.Text = CalculatorExtensions.GünlükSuIhtiyaciHesapla(kilo).ToString() + " lt";
            lblGuncelKAH.Text = CalculatorExtensions.KalpAtisHiziHesapla(yas).ToString() + " atım/dakika";

            lblKilo.Text = kilo.ToString();
            lblHarcananKalori.Text = _userDetail.UserTarget == null ? "Hedeflerinizi giriniz." : _userDetail.UserTarget.TargetCalorie.ToString() + " Kcal";
            lblAlinanKalori.Text = CalculateCalori().ToString() + " Kcal";
        }

        private double CalculateCalori()
        {
            var breakfastMealList = dBQueries.ViewToGetMeals(MealType.Breakfast, userManager.CurrentUser.UserId, DateTime.Now.Date);
            var lunchMealList = dBQueries.ViewToGetMeals(MealType.Lunch, userManager.CurrentUser.UserId, DateTime.Now.Date);
            var dinnerMealList = dBQueries.ViewToGetMeals(MealType.Dinner, userManager.CurrentUser.UserId, DateTime.Now.Date);
            var snackMealList = dBQueries.ViewToGetMeals(MealType.Snack, userManager.CurrentUser.UserId, DateTime.Now.Date);

            double totalCalori = 0;

            foreach (var item in breakfastMealList)
            {
                totalCalori += item.TotalCalorie;
            }

            foreach (var item in lunchMealList)
            {
                totalCalori += item.TotalCalorie;
            }

            foreach (var item in dinnerMealList)
            {
                totalCalori += item.TotalCalorie;
            }

            foreach (var item in snackMealList)
            {
                totalCalori += item.TotalCalorie;
            }
            return Math.Round(totalCalori, 2);
        }

        private void ClearLabels()
        {

            lblGuncelBMH.Text = string.Empty;
            lblGuncelGKI.Text = string.Empty;
            lblGuncelGSI.Text = string.Empty;
            lblGuncelIdealKilo.Text = string.Empty;
            lblGuncelKAH.Text = string.Empty;
            lblGuncelVKI.Text = string.Empty;
            lblGuncelVYO.Text = string.Empty;




        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            formHedef = new FormHedef() { TopLevel = false, TopMost = true };
            if (formDuzenle != null)
                formDuzenle.Hide();
            pnlYanPanel.Controls.Add(formHedef);
            formHedef.Show();
            
        }
    }

}
