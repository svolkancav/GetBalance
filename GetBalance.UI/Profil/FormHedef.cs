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
using GetBalance.UI.Singeltons;

namespace GetBalance.UI
{
	public partial class FormHedef : Form
	{
		UserManager userManager;

		GenericRepository<UserTarget> userTargetRepository;
		public FormHedef()
		{
			InitializeComponent();
			userManager = UserManager.Instance;
			userTargetRepository = new GenericRepository<UserTarget>();

		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			double hedeflenenProtein = double.Parse(txtHedefProtein.Text);
			double hedeflenenCarb = double.Parse(txtHedefCarbon.Text);
			double hedeflenenYag = double.Parse(txtHedefYag.Text);
			double hedeflenenKalori = double.Parse(txtHedefKalori.Text);
			double hedeflenenKilo = double.Parse(txtHedefKilo.Text);


			UserDetail userDetail = userManager.CurrentUser.UserDetail;

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

		}

	}
}
