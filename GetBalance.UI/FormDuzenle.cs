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
    public partial class FormDuzenle : Form
    {

        UserDetail _userDetail;
        AppDbContext context;
        GenericRepository<UserDetail> _userDetailRepo;
        int _userId;

        public FormDuzenle()
        {
            InitializeComponent();
        }

        public FormDuzenle(int userID)
        {
            InitializeComponent();
            _userId = userID;

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


                _userDetail = _userDetailRepo.GetById(_userId);

                _userDetail.Height = boy;
                _userDetail.CurrentWeight = kilo;
                _userDetail.NeckCircumference = boyun;
                _userDetail.WaistCircumference = bel;
                _userDetail.HipCircumference = kalca;
                _userDetail.ActivityLevel = activity;
                _userDetail.TrainingLevel = training;
                context.SaveChanges();


            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız !");
            }
            

            



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
