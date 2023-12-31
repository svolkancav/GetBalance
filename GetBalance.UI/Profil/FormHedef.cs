﻿using System;
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
using GetBalance.DATA.Enums;
using GetBalance.UI.Events;
using GetBalance.UI.Extensions;
using GetBalance.UI.Repositories;
using GetBalance.UI.Singeltons;

namespace GetBalance.UI
{
	public partial class FormHedef : Form
	{
		UserManager userManager;

		UserTargetRepository userTargetRepository;
        UserDetail userDetail;

		int günlükKaloriİhtiyaci;

		public FormHedef()
        {
            InitializeComponent();
            userManager = UserManager.Instance;
            userTargetRepository = new UserTargetRepository();

			FormEventService.Instance.TargetFormOpen += KiloAlmaVermeHesapla;
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

				if(hedeflenenProtein <= 0.0 || hedeflenenYag <= 0.0 || hedeflenenCarb <= 0.0 || hedeflenenKalori <= 0.0 || hedeflenenKilo <= 0.0)
				{
                    MessageBox.Show("Girilen değerler 0'dan küçük olamaz!");
                    return;
                }

				double toplamBesinDegeri = hedeflenenProtein + hedeflenenCarb + hedeflenenYag;

                if (toplamBesinDegeri != 100)
				{
					MessageBox.Show("Hedeflenen besin değerlerinin toplamı 100 olmalıdır!");
					return;
				}

				UserTarget userTarget = new UserTarget();
				userTarget= userManager.CurrentUser.UserDetail.UserTarget ?? new UserTarget();

				userTarget.TargetProteinPercentage = hedeflenenProtein;
				userTarget.TargetCarbPercentage = hedeflenenCarb;
				userTarget.TargetFatPercentage = hedeflenenYag;
				userTarget.TargetCalorie = hedeflenenKalori;
				userTarget.TargetWeight = hedeflenenKilo;
				userTarget.UserDetailId = userManager.CurrentUser.UserDetail.UserDetailId;
				if (userManager.CurrentUser.UserDetail.UserTarget == null)
					userTargetRepository.Add(userTarget);
				else
					userTargetRepository.Update(userTarget, userManager.CurrentUser.UserDetail.UserTarget.UserTargetId);

				userManager.CurrentUser.UserDetail.UserTarget = userTarget;

				ClearFields();


				MessageBox.Show($"{(btnKaydet.Text == "Kaydet" ? "Kaydetme" : "Güncelleme")} başarılı");
				FormEventService.Instance.OnUserTagetUpdated();

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
			günlükKaloriİhtiyaci = 0;
			btnKaydet.Text = userDetail.UserTarget == null ? "Kaydet" : "Güncelle";

			

			KiloAlmaVermeHesapla();

			
		}
		#region KiloAlma-Verme Label doldurma
		private void KiloAlmaVermeHesapla()
		{
			if (userDetail != null)
			{
				int boy = Convert.ToInt32(userDetail.Height);
				int kilo = Convert.ToInt32(userDetail.CurrentWeight);
				Gender gender = userDetail.Gender;
				string cinsiyet = gender.ToString();
				DateTime dateTime = userDetail.BirthDate;
				int yas = DateTime.Now.Year - dateTime.Year;
				ActivityLevel activity = userDetail.ActivityLevel;
				günlükKaloriİhtiyaci = CalculatorExtensions.GunlukKaloriIhtiyaci(boy, kilo, yas, activity, cinsiyet);
				if (userDetail.UserTarget != null)
					FillTextBox();
			}

			lblKiloAlmaBilgi.Text = $"Kilo almak için önerilen Hedef Kalori : {günlükKaloriİhtiyaci + 300} Kcal ";
			lblKiloVermeBilgi.Text = $"Kilo vermek için önerilen Hedef Kalori : {günlükKaloriİhtiyaci - 300} Kcal ";
		}
		#endregion
		private void FillTextBox()
		{
			userDetail = userManager.CurrentUser.UserDetail;
			txtHedefKilo.Text = userDetail.UserTarget.TargetWeight.ToString();
			txtHedefKalori.Text = userDetail.UserTarget.TargetCalorie.ToString();
			txtHedefCarbon.Text = userDetail.UserTarget.TargetCarbPercentage.ToString();
			txtHedefProtein.Text = userDetail.UserTarget.TargetProteinPercentage.ToString();
			txtHedefYag.Text = userDetail.UserTarget.TargetFatPercentage.ToString();

		}
	}
}
