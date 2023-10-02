namespace GetBalance.UI
{
	partial class FormBenimKilom
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
			label1 = new Label();
			lblMevcutKilo = new Label();
			label3 = new Label();
			label4 = new Label();
			lblBaslangicKilo = new Label();
			lblHedefKilo = new Label();
			label7 = new Label();
			lblVerilenKilo = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(263, 9);
			label1.Name = "label1";
			label1.Size = new Size(122, 21);
			label1.TabIndex = 0;
			label1.Text = "Mevcut Ağırlığı";
			// 
			// lblMevcutKilo
			// 
			lblMevcutKilo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblMevcutKilo.Location = new Point(263, 43);
			lblMevcutKilo.Name = "lblMevcutKilo";
			lblMevcutKilo.Size = new Size(122, 20);
			lblMevcutKilo.TabIndex = 1;
			lblMevcutKilo.Text = "100";
			lblMevcutKilo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(47, 109);
			label3.Name = "label3";
			label3.Size = new Size(135, 21);
			label3.TabIndex = 3;
			label3.Text = "Başlangıç Ağırlığı";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(272, 109);
			label4.Name = "label4";
			label4.Size = new Size(113, 21);
			label4.TabIndex = 4;
			label4.Text = "Hedef Ağırlığı";
			// 
			// lblBaslangicKilo
			// 
			lblBaslangicKilo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblBaslangicKilo.Location = new Point(47, 146);
			lblBaslangicKilo.Name = "lblBaslangicKilo";
			lblBaslangicKilo.Size = new Size(135, 20);
			lblBaslangicKilo.TabIndex = 7;
			lblBaslangicKilo.Text = "100";
			lblBaslangicKilo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblHedefKilo
			// 
			lblHedefKilo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblHedefKilo.Location = new Point(272, 146);
			lblHedefKilo.Name = "lblHedefKilo";
			lblHedefKilo.Size = new Size(113, 20);
			lblHedefKilo.TabIndex = 12;
			lblHedefKilo.Text = "100";
			lblHedefKilo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label7.Location = new Point(474, 109);
			label7.Name = "label7";
			label7.Size = new Size(187, 21);
			label7.TabIndex = 9;
			label7.Text = "Bugüne Kadarki Değişim";
			// 
			// lblVerilenKilo
			// 
			lblVerilenKilo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblVerilenKilo.Location = new Point(474, 146);
			lblVerilenKilo.Name = "lblVerilenKilo";
			lblVerilenKilo.Size = new Size(187, 20);
			lblVerilenKilo.TabIndex = 11;
			lblVerilenKilo.Text = "100";
			lblVerilenKilo.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// FormBenimKilom
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(710, 259);
			Controls.Add(lblHedefKilo);
			Controls.Add(lblVerilenKilo);
			Controls.Add(label7);
			Controls.Add(lblBaslangicKilo);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(lblMevcutKilo);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "FormBenimKilom";
			Text = "FormBenimKilom";
			Load += FormBenimKilom_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lblMevcutKilo;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label lblBaslangicKilo;
		private Label lblHedefKilo;
		private Label label7;
		private Label label9;
		private Label lblVerilenKilo;
	}
}