using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetBalance.DATA;
using GetBalance.UI.Singeltons;

namespace GetBalance.UI
{
	public partial class FormBenimKilom : Form
	{
		UserManager userManager;
		User user;

		public FormBenimKilom()
		{
			InitializeComponent();
			userManager = UserManager.Instance;
			user = userManager.CurrentUser;
		}

		private void FormBenimKilom_Load(object sender, EventArgs e)
		{

			lblMevcutKilo.Text = lblBaslangicKilo.Text = user.UserDetail.CurrentWeight.ToString();
			


            if (user.UserDetail.UserTarget == null)
			{
				return;
			}

			lblHedefKilo.Text = user.UserDetail.UserTarget.TargetWeight.ToString();
            lblBaslangicKilo.Text = user.UserDetail.UserTarget.StartingWeight.ToString();
			lblHedefKilo.Text = user.UserDetail.UserTarget.TargetWeight.ToString();
			lblVerilenKilo.Text= (user.UserDetail.CurrentWeight - user.UserDetail.UserTarget.TargetWeight).ToString();
		}
	}
}
