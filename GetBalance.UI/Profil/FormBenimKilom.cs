﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetBalance.DATA.Entities;
using GetBalance.UI.Events;
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

			FormEventService.Instance.UserTagetUpdated += FillLabel;
			FormEventService.Instance.UserDetailUpdated += FillLabel;
		}

		private void FormBenimKilom_Load(object sender, EventArgs e)
		{
			FillLabel();
		}

		private void FillLabel()
		{
			lblMevcutKilo.Text = lblBaslangicKilo.Text = user.UserDetail.CurrentWeight.ToString();

			if (user.UserDetail.UserTarget == null)
			{
				return;
			}

			lblHedefKilo.Text = user.UserDetail.UserTarget.TargetWeight.ToString() + " kg";
			lblBaslangicKilo.Text = user.UserDetail.UserTarget.StartingWeight.ToString() + " kg";
			lblMevcutKilo.Text = user.UserDetail.CurrentWeight.ToString() + " kg";
			lblVerilenKilo.Text = (user.UserDetail.CurrentWeight - user.UserDetail.UserTarget.StartingWeight).ToString() + " kg";
		}
	}
}
