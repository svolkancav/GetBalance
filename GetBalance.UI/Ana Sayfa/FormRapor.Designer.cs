namespace GetBalance.UI
{
	partial class FormRapor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			grpbxKiyasRaporu = new GroupBox();
			rbHaftalik = new RadioButton();
			rbAylik = new RadioButton();
			label3 = new Label();
			cmbxOgun2 = new ComboBox();
			listView1 = new ListView();
			label2 = new Label();
			cmbxKategori = new ComboBox();
			grpbxYemekcesidiRaporu = new GroupBox();
			listView2 = new ListView();
			label1 = new Label();
			cmbxOgun = new ComboBox();
			grpbxKiyasRaporu.SuspendLayout();
			grpbxYemekcesidiRaporu.SuspendLayout();
			SuspendLayout();
			// 
			// grpbxKiyasRaporu
			// 
			grpbxKiyasRaporu.Controls.Add(rbHaftalik);
			grpbxKiyasRaporu.Controls.Add(rbAylik);
			grpbxKiyasRaporu.Controls.Add(label3);
			grpbxKiyasRaporu.Controls.Add(cmbxOgun2);
			grpbxKiyasRaporu.Controls.Add(listView1);
			grpbxKiyasRaporu.Controls.Add(label2);
			grpbxKiyasRaporu.Controls.Add(cmbxKategori);
			grpbxKiyasRaporu.Dock = DockStyle.Left;
			grpbxKiyasRaporu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			grpbxKiyasRaporu.Location = new Point(0, 0);
			grpbxKiyasRaporu.Name = "grpbxKiyasRaporu";
			grpbxKiyasRaporu.Size = new Size(520, 685);
			grpbxKiyasRaporu.TabIndex = 0;
			grpbxKiyasRaporu.TabStop = false;
			grpbxKiyasRaporu.Text = "Kıyas Raporu";
			// 
			// rbHaftalik
			// 
			rbHaftalik.AutoSize = true;
			rbHaftalik.Location = new Point(416, 75);
			rbHaftalik.Name = "rbHaftalik";
			rbHaftalik.Size = new Size(89, 25);
			rbHaftalik.TabIndex = 10;
			rbHaftalik.TabStop = true;
			rbHaftalik.Text = "Haftalık";
			rbHaftalik.UseVisualStyleBackColor = true;
			rbHaftalik.CheckedChanged += Kiyasla;
			// 
			// rbAylik
			// 
			rbAylik.AutoSize = true;
			rbAylik.Location = new Point(416, 38);
			rbAylik.Name = "rbAylik";
			rbAylik.Size = new Size(67, 25);
			rbAylik.TabIndex = 9;
			rbAylik.TabStop = true;
			rbAylik.Text = "Aylık";
			rbAylik.UseVisualStyleBackColor = true;
			rbAylik.CheckedChanged += Kiyasla;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(228, 39);
			label3.Name = "label3";
			label3.Size = new Size(163, 21);
			label3.TabIndex = 8;
			label3.Text = "Lütfen Öğün Seçiniz";
			// 
			// cmbxOgun2
			// 
			cmbxOgun2.FormattingEnabled = true;
			cmbxOgun2.Location = new Point(214, 71);
			cmbxOgun2.Name = "cmbxOgun2";
			cmbxOgun2.Size = new Size(186, 29);
			cmbxOgun2.TabIndex = 7;
			cmbxOgun2.SelectionChangeCommitted += Kiyasla;
			// 
			// listView1
			// 
			listView1.Location = new Point(37, 121);
			listView1.Name = "listView1";
			listView1.Size = new Size(453, 514);
			listView1.TabIndex = 4;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 38);
			label2.Name = "label2";
			label2.Size = new Size(186, 21);
			label2.TabIndex = 3;
			label2.Text = "Lütfen Kategori Seçiniz";
			// 
			// cmbxKategori
			// 
			cmbxKategori.FormattingEnabled = true;
			cmbxKategori.Location = new Point(12, 71);
			cmbxKategori.Name = "cmbxKategori";
			cmbxKategori.Size = new Size(186, 29);
			cmbxKategori.TabIndex = 2;
			cmbxKategori.SelectionChangeCommitted += Kiyasla;
			// 
			// grpbxYemekcesidiRaporu
			// 
			grpbxYemekcesidiRaporu.Controls.Add(listView2);
			grpbxYemekcesidiRaporu.Controls.Add(label1);
			grpbxYemekcesidiRaporu.Controls.Add(cmbxOgun);
			grpbxYemekcesidiRaporu.Dock = DockStyle.Right;
			grpbxYemekcesidiRaporu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			grpbxYemekcesidiRaporu.Location = new Point(578, 0);
			grpbxYemekcesidiRaporu.Name = "grpbxYemekcesidiRaporu";
			grpbxYemekcesidiRaporu.Size = new Size(522, 685);
			grpbxYemekcesidiRaporu.TabIndex = 1;
			grpbxYemekcesidiRaporu.TabStop = false;
			grpbxYemekcesidiRaporu.Text = "Yemek Çeşidi Raporu";
			// 
			// listView2
			// 
			listView2.Location = new Point(33, 121);
			listView2.Name = "listView2";
			listView2.Size = new Size(453, 514);
			listView2.TabIndex = 5;
			listView2.UseCompatibleStateImageBehavior = false;
			listView2.View = View.Details;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(182, 38);
			label1.Name = "label1";
			label1.Size = new Size(163, 21);
			label1.TabIndex = 1;
			label1.Text = "Lütfen Öğün Seçiniz";
			// 
			// cmbxOgun
			// 
			cmbxOgun.FormattingEnabled = true;
			cmbxOgun.Location = new Point(142, 71);
			cmbxOgun.Name = "cmbxOgun";
			cmbxOgun.Size = new Size(235, 29);
			cmbxOgun.TabIndex = 0;
			cmbxOgun.SelectionChangeCommitted += EnCokTuketilenYemek;
			// 
			// FormRapor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1100, 685);
			Controls.Add(grpbxYemekcesidiRaporu);
			Controls.Add(grpbxKiyasRaporu);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormRapor";
			Text = "FormRapor";
			Load += FormRapor_Load;
			grpbxKiyasRaporu.ResumeLayout(false);
			grpbxKiyasRaporu.PerformLayout();
			grpbxYemekcesidiRaporu.ResumeLayout(false);
			grpbxYemekcesidiRaporu.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpbxKiyasRaporu;
		private GroupBox grpbxYemekcesidiRaporu;
		private ListView listView1;
		private Label label2;
		private ComboBox cmbxKategori;
		private ListView listView2;
		private Label label1;
		private ComboBox cmbxOgun;
		private Label label3;
		private ComboBox cmbxOgun2;
		private RadioButton rbHaftalik;
		private RadioButton rbAylik;
	}
}