using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DAL;
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

namespace GetBalance.UI
{
    public partial class FormHomePage2 : Form
    {

        Form formDuzenle;
        public Point downPoint = Point.Empty;

        UserDetail _userDetail;
        int _userId;
        AppDbContext context;
        GenericRepository<UserDetail> _userDetailRepo;



        public FormHomePage2()
        {
            InitializeComponent();

        }

        public FormHomePage2(int userID)
        {

            _userId = userID;
            InitializeComponent();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            formDuzenle = new FormDuzenle(_userId) { TopLevel = false, TopMost = true };
            pnlYanPanel.Controls.Add(formDuzenle);
            formDuzenle.Show();

        }

        private void FormHomePage2_Load(object sender, EventArgs e)
        {

            #region Database e user girilince açılacak.
            //_userDetail = new UserDetail();
            //context = new AppDbContext();
            //_userDetailRepo = new GenericRepository<UserDetail>();
            //_userDetail = _userDetailRepo.GetById(_userId);

            //ClearLabels();

            //int boy = Convert.ToInt32(_userDetail.Height);
            //int kilo = Convert.ToInt32(_userDetail.CurrentWeight);
            //int neckCircum = Convert.ToInt32(_userDetail.NeckCircumference);
            //int waistCircum = Convert.ToInt32(_userDetail.WaistCircumference);
            //int hipCircum = Convert.ToInt32(_userDetail.HipCircumference);
            //Gender gender = _userDetail.Gender;
            //string cinsiyet = gender.ToString();
            //DateTime dateTime = _userDetail.BirthDate;
            //int yas = DateTime.Now.Year - dateTime.Year;
            //ActivityLevel activity = _userDetail.ActivityLevel;
            //TrainingLevel training = _userDetail.TrainingLevel;


            //lblGuncelVKI.Text = CalculatorExtensions.VKİHesapla(kilo, boy).ToString();
            //lblGuncelBMH.Text = CalculatorExtensions.BMRHesapla(boy, kilo, yas, cinsiyet).ToString();
            //lblGuncelVYO.Text = CalculatorExtensions.VücutYağOraniHesapla(waistCircum, neckCircum, hipCircum, boy, cinsiyet).ToString();
            //lblGuncelIdealKilo.Text = CalculatorExtensions.IdealKiloHesapla(boy, cinsiyet).ToString();
            //lblGuncelGKI.Text = CalculatorExtensions.GunlukKaloriIhtiyaci(boy, kilo, yas, activity, cinsiyet).ToString();
            //lblGuncelGSI.Text = CalculatorExtensions.GünlükSuIhtiyaciHesapla(kilo).ToString();
            //lblGuncelKAH.Text = CalculatorExtensions.KalpAtisHiziHesapla(yas).ToString();
            #endregion



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
    }
}
