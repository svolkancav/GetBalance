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
using GetBalance.DATA.Entities;
using GetBalance.UI.Singeltons;

namespace GetBalance.UI
{
    public partial class FormAyarlar : Form
    {
        GenericRepository<User> userRepo;
        UserManager userManager;
        public FormAyarlar()
        {
            InitializeComponent();
            userRepo = new GenericRepository<User>();
            userManager = UserManager.Instance;
        }

        private void btnHesabiSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hesabınızı silmek istediğinize emin misiniz?", "Hesap Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // HesapSilme metodu
                MessageBox.Show("Hesabınız başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                userRepo.Delete(userManager.CurrentUser.UserId);
                Application.Exit();
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hesabınızdan çıkmak istediğinize emin misiniz?", "Hesaptan Çıkma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // HesaptanCikma metodu
                MessageBox.Show("Çıkış Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
