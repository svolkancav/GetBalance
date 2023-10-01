using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DAL;
using GetBalance.DATA;
using GetBalance.DATA.Enums;
using GetBalance.UI.Extensions;
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
        GenericRepository<UserDetail> _userDetailRepo;

        UserManager userManager;

        public FormDuzenle()
        {
            InitializeComponent();
            userManager = UserManager.Instance;
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
                ActivityLevel activity = (ActivityLevel)cbxAktiviteSeviyesi.SelectedItem;
                TrainingLevel training = (TrainingLevel)cmbTraining.SelectedItem;

                _userDetail = _userDetailRepo.GetById(userManager.CurrentUser.UserId);
                _userDetail.Height = boy;
                _userDetail.CurrentWeight = kilo;
                _userDetail.NeckCircumference = boyun;
                _userDetail.WaistCircumference = bel;
                _userDetail.HipCircumference = kalca;
                _userDetail.ActivityLevel = activity;
                _userDetail.TrainingLevel = training;
                context.SaveChanges();
                ClearFields();

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
            _userDetailRepo = new GenericRepository<UserDetail>();

            LoadComboBoxes();



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
