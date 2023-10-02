using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DAL;
using GetBalance.DATA.Entities;
using GetBalance.DATA.Enums;
using GetBalance.UI.Events;
using GetBalance.UI.Extensions;
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

namespace GetBalance.UI
{
    public partial class FormDuzenle : Form
    {

        UserDetail _userDetail;
        AppDbContext context;
        GenericRepository<UserDetail> userDetailrepository;
        UserTargetRepository userTargetRepository;

		UserManager userManager;

        public FormDuzenle()
        {
            InitializeComponent();
            userManager = UserManager.Instance;
			userTargetRepository = new UserTargetRepository();


		}




        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                int boy = Convert.ToInt32(txtBoy.Text);
                int kilo = Convert.ToInt32(txtKilo.Text);
                int boyun = Convert.ToInt32(txtBoyunCevresi.Text);
                int bel = Convert.ToInt32(txtBelCevresi.Text);
                int kalca = Convert.ToInt32(txtKalcaCevresi.Text);
                ActivityLevel activity = (ActivityLevel)cbxAktiviteSeviyesi.SelectedValue;
                TrainingLevel training = (TrainingLevel)cmbTraining.SelectedValue;

                _userDetail = userDetailrepository.GetById(userManager.CurrentUser.UserId);
                _userDetail.Height = boy;
                _userDetail.CurrentWeight = kilo;
                _userDetail.NeckCircumference = boyun;
                _userDetail.WaistCircumference = bel;
                _userDetail.HipCircumference = kalca;
                _userDetail.ActivityLevel = activity;
                _userDetail.TrainingLevel = training;
                context.UserDetails.Update(_userDetail);
                context.SaveChanges();

				userManager.CurrentUser.UserDetail = userDetailrepository.GetAll().Find(us => us.UserId == userManager.CurrentUser.UserId);
				ClearFields();

				FormEventService.Instance.OnUserDetailUpdated();

				MessageBox.Show($"{(btnGuncelle.Text == "Kaydet" ? "Kaydetme" : "Güncelleme")} başarılı");

                
			}
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız !");
            }

        }

        private void ClearFields()
        {
            txtBoy.Text = string.Empty;
            txtBelCevresi.Text = string.Empty;
            txtBoyunCevresi.Text = string.Empty;
            txtKalcaCevresi.Text = string.Empty;
            txtKilo.Text = string.Empty;
            cmbTraining.SelectedIndex = -1;
            cbxAktiviteSeviyesi.SelectedIndex = -1;
        }

        private void FormDuzenle_Load(object sender, EventArgs e)
        {
            context = new AppDbContext();
            userDetailrepository = new GenericRepository<UserDetail>();

			btnGuncelle.Text = userManager.CurrentUser.UserDetail==null? "Kaydet":"Güncelle";

			LoadComboBoxes();
            if (userManager.CurrentUser.UserDetail!=null)
			FillTextBox();
        }

		private void FillTextBox()
		{
			txtBelCevresi.Text = userManager.CurrentUser.UserDetail.WaistCircumference.ToString();
            txtBoyunCevresi.Text = userManager.CurrentUser.UserDetail.NeckCircumference.ToString();
            txtBoy.Text = userManager.CurrentUser.UserDetail.Height.ToString();
            txtKalcaCevresi.Text = userManager.CurrentUser.UserDetail.HipCircumference.ToString();
            txtKilo.Text = userManager.CurrentUser.UserDetail.CurrentWeight.ToString();
            cbxAktiviteSeviyesi.SelectedValue = (int)userManager.CurrentUser.UserDetail.ActivityLevel;
            cmbTraining.SelectedValue = (int)userManager.CurrentUser.UserDetail.TrainingLevel;
            
		}

		private void LoadComboBoxes()
        {
            cbxAktiviteSeviyesi.Items.Clear();
            cmbTraining.Items.Clear();

            cbxAktiviteSeviyesi.DataSource = Enum.GetValues(typeof(ActivityLevel))
                .Cast<ActivityLevel>()
                .Select(x => new
                {
                    Value = (int)x,
                    DisplayName = x.DisplayName()
                }).ToList();
            cbxAktiviteSeviyesi.DisplayMember = "DisplayName";
            cbxAktiviteSeviyesi.ValueMember = "Value";

            cbxAktiviteSeviyesi.SelectedIndex = -1;



            cmbTraining.DataSource = Enum.GetValues(typeof(TrainingLevel))
                .Cast<TrainingLevel>()
                .Select(x => new
                {
                    Value = (int)x,
                    DisplayName = x.DisplayName()
                }).ToList();
            cmbTraining.DisplayMember = "DisplayName";
            cmbTraining.ValueMember = "Value";

            cmbTraining.SelectedIndex = -1;
        }
    }
}
