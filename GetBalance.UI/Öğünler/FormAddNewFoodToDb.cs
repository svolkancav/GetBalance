using _16_DBFirst_RepositoryDesing_Nortwind.Repositories;
using GetBalance.DATA.Entities;
using GetBalance.DATA.Enums;
using GetBalance.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GetBalance.UI
{
	public partial class FormAddNewFoodToDb : Form
	{
		GenericRepository<FoodCategory> _categoryRepo;
		GenericRepository<Food> _foodRepo;

		OpenFileDialog openFileDialog;


		string resimYolu;
		public FormAddNewFoodToDb()
		{
			InitializeComponent();
			openFileDialog = new OpenFileDialog();
			_categoryRepo = new GenericRepository<FoodCategory>();
			_foodRepo = new GenericRepository<Food>();

		}

		private void FormAddNewFoodToDb_Load(object sender, EventArgs e)
		{
			CleanForm();
			FillComboBoxKategoriler();
			FillComboBoxPorsiyonlar();

		}

		private void CleanForm()
		{
			txtYemekAdi.Text = string.Empty;
			txtPorsiyonMiktari.Text = string.Empty;
			txtKarb.Text = string.Empty;
			txtProtein.Text = string.Empty;
			txtYag.Text = string.Empty;
			cmbPorsiyonlar.SelectedIndex = -1;
			cmbPorsiyonlar.SelectedText = "Seçiniz";
			cmbKategoriler.SelectedIndex = -1;
			cmbKategoriler.SelectedText = "Kategori seçiniz";
			pbNewFood.Image = Properties.Resources.add_image_128;
		}
		private void FillComboBoxPorsiyonlar()
		{
			cmbPorsiyonlar.Items.Clear();
			cmbPorsiyonlar.DataSource = Enum.GetValues(typeof(PortionName)).Cast<PortionName>().Select
				(x => new
				{
					Value = (PortionName)x,
					DisplayName = x.DisplayName()

				}).ToList();
			cmbPorsiyonlar.DisplayMember = "DisplayName";
			cmbPorsiyonlar.ValueMember = "Value";
			cmbPorsiyonlar.SelectedIndex = -1;
			cmbPorsiyonlar.SelectedText = "Seçiniz";

		}

		private void FillComboBoxKategoriler()
		{
			cmbKategoriler.Items.Clear();
			cmbKategoriler.DataSource = _categoryRepo.GetAll();
			cmbKategoriler.ValueMember = "FoodCategoryId";
			cmbKategoriler.DisplayMember = "Name";

			cmbKategoriler.SelectedIndex = -1;
			cmbKategoriler.SelectedText = "Kategori seçiniz";

		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			List<Food> foods = _foodRepo.GetAll();

			if (cmbPorsiyonlar.SelectedIndex == -1 || cmbPorsiyonlar.SelectedIndex == -1)
			{
				MessageBox.Show("Lütfen porsiyon tipini ve kategoriyi seçiniz!");
			}
			else
			{
				bool dogruMuPorMik = int.TryParse(txtPorsiyonMiktari.Text.Trim(), out int porsiyonMiktari);
				bool dogruMuKarb = double.TryParse(txtKarb.Text.Trim(), out double karb);
				bool dogruMuPro = double.TryParse(txtProtein.Text.Trim(), out double protein);
				bool dogruMuYag = double.TryParse(txtYag.Text.Trim(), out double yag);

				string yemekAdi = txtYemekAdi.Text.Trim();

				List<Food> foodKontrolList = foods.FindAll(f => f.Name == yemekAdi);
				bool yemekVarMi = !(foodKontrolList.Count == 0);
				bool yemekAdiBosMu = String.IsNullOrEmpty(yemekAdi);
				bool porsiyonIsmiVarMi = foodKontrolList.Find(f => f.PortionName == (PortionName)cmbPorsiyonlar.SelectedValue) != null;

				if ((yemekVarMi && porsiyonIsmiVarMi))
				{
					txtBilgi.ForeColor = Color.Red;
					txtBilgi.Text = "Girilen yiyecekten aynı porsiyon tipinde mevcut!";
				}
				else if (dogruMuPorMik && dogruMuKarb && dogruMuPro && dogruMuYag && !yemekAdiBosMu)
				{
					try
					{
						_foodRepo.Add(new Food()
						{
							Name = yemekAdi,
							UnitPortionQuantity = porsiyonMiktari,
							PortionName = (PortionName)cmbPorsiyonlar.SelectedValue,
							Calories = CalculatorExtensions.KaloriHesapla(karb, protein, yag),
							Carbohydrate = karb,
							Protein = protein,
							Fat = yag,
							CategoryId = (int)cmbKategoriler.SelectedValue,
							Picture = PictureTools.CopyPicture(resimYolu)

						});

						txtBilgi.ForeColor = Color.Green;
						txtBilgi.Text = "Yeni yemek eklendi!";
						CleanForm();

					}
					catch (Exception)
					{
						txtBilgi.ForeColor = Color.Red;
						txtBilgi.Text = "Yeni yemek eklerken bir hata oluştu!";
					}
				}
				else
				{
					MessageBox.Show("Lütfen miktarları doğru giriniz!");
				}

			}

		}

		int space = 0;
		private void txt_KeyPress(object sender, KeyPressEventArgs e)
		{
			System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)sender;

			char ch = e.KeyChar;
			if (Char.IsLetter(e.KeyChar) && (txt.Text.Length == 0 || (txt.SelectionStart > 0 && txt.Text[txt.SelectionStart - 1] == ' ')))
			{
				e.KeyChar = Char.ToUpper(e.KeyChar);
			}
			else if (!Char.IsLetter(ch) && ch != 8 && ch != 32)
			{
				e.Handled = true;
			}
			else if (Char.IsLetter(ch)) space = 0;
			
				if (ch == 32)
				{
					space++;
					if (space > 1)
					{
						e.Handled = true;
					}
				}
		}
		private void btnGeri_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void pbNewFood_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				resimYolu = openFileDialog.FileName;

				pbNewFood.Image = new Bitmap(openFileDialog.FileName);
			}
		}

		private void pnlYeniYemekEkle_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
