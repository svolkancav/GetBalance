using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormHedef : Form
    {
        UserManager userManager;

        GenericRepository<UserTarget> userTargetRepository;
        UserDetail userDetail;
        public FormHedef()
        {
            InitializeComponent();
            userManager = UserManager.Instance;
            userTargetRepository = new GenericRepository<UserTarget>();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                double hedeflenenProtein = double.Parse(txtHedefProtein.Text);
                double hedeflenenCarb = double.Parse(txtHedefCarbon.Text);
                double hedeflenenYag = double.Parse(txtHedefYag.Text);
                double hedeflenenKalori = double.Parse(txtHedefKalori.Text);
                double hedeflenenKilo = double.Parse(txtHedefKilo.Text);

                

                UserTarget userTarget = new UserTarget()
                {
                    StartingWeight = userDetail.CurrentWeight,
                    TargetWeight = hedeflenenKilo,
                    StartingDate = DateTime.Now,
                    TargetCalorie = hedeflenenKalori,
                    TargetCarbPercentage = hedeflenenCarb,
                    TargetProteinPercentage = hedeflenenProtein,
                    TargetFatPercentage = hedeflenenYag,
                    UserDetailId = userDetail.UserDetailId
                };

                userTargetRepository.Add(userTarget);

                userManager.CurrentUser.UserDetail.UserTarget = userTarget;

                //TODO: 2. kez hedef girmeye çalıştığımızda hata alıyoruz.


                ClearFields();
                MessageBox.Show("Hedefleriniz kaydedilmiştir.");
                this.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Geçerli bir değer giriniz !");

            }

        }
        private void ClearFields()
        {
            txtHedefCarbon.Text = string.Empty;
            txtHedefKalori.Text = string.Empty;
            txtHedefKilo.Text = string.Empty;
            txtHedefProtein.Text = string.Empty;
            txtHedefYag.Text = string.Empty;
        }

        private void FormHedef_Load(object sender, EventArgs e)
        {
            userDetail = userManager.CurrentUser.UserDetail;
            #region KiloAlma-Verme Label doldurma
            int boy = Convert.ToInt32(userDetail.Height);
            int kilo = Convert.ToInt32(userDetail.CurrentWeight);
            Gender gender = userDetail.Gender;
            string cinsiyet = gender.ToString();
            DateTime dateTime = userDetail.BirthDate;
            int yas = DateTime.Now.Year - dateTime.Year;
            ActivityLevel activity = userDetail.ActivityLevel;

            int günlükKaloriİhtiyaci = CalculatorExtensions.GunlukKaloriIhtiyaci(boy, kilo, yas, activity, cinsiyet);

            lblKiloAlmaBilgi.Text = $"Kilo vermek için önerilen Hedef Kalori : {günlükKaloriİhtiyaci + 300} Kcal ";
            lblKiloVermeBilgi.Text = $"Kilo vermek için önerilen Hedef Kalori : {günlükKaloriİhtiyaci - 300} Kcal ";

            #endregion
        }
    }
}
