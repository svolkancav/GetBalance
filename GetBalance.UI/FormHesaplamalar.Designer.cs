namespace GetBalance.UI
{
    partial class FormHesaplamalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHesaplamalar));
            btnVKE = new Button();
            btnBMH = new Button();
            pnlHesaplamalar1 = new Panel();
            btnMKAH = new Button();
            btnGSI = new Button();
            btnIdealKilo = new Button();
            btnVYO = new Button();
            btnGKİ = new Button();
            btnYVK = new Button();
            pnlHesaplamalar2 = new Panel();
            pnlHesaplamalar1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVKE
            // 
            btnVKE.BackColor = Color.FromArgb(15, 194, 192);
            btnVKE.FlatAppearance.BorderSize = 0;
            btnVKE.FlatStyle = FlatStyle.Flat;
            btnVKE.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVKE.ForeColor = Color.White;
            btnVKE.Image = (Image)resources.GetObject("btnVKE.Image");
            btnVKE.ImageAlign = ContentAlignment.MiddleLeft;
            btnVKE.Location = new Point(0, 33);
            btnVKE.Name = "btnVKE";
            btnVKE.Size = new Size(230, 41);
            btnVKE.TabIndex = 0;
            btnVKE.Text = "        Vücut Kitle Endeksi ( BMI)";
            btnVKE.UseVisualStyleBackColor = false;
            btnVKE.Click += btnVKE_Click;
            // 
            // btnBMH
            // 
            btnBMH.BackColor = Color.FromArgb(15, 194, 192);
            btnBMH.FlatStyle = FlatStyle.Flat;
            btnBMH.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBMH.ForeColor = Color.White;
            btnBMH.Image = (Image)resources.GetObject("btnBMH.Image");
            btnBMH.ImageAlign = ContentAlignment.MiddleLeft;
            btnBMH.Location = new Point(0, 104);
            btnBMH.Name = "btnBMH";
            btnBMH.Size = new Size(230, 41);
            btnBMH.TabIndex = 1;
            btnBMH.Text = "      Bazal Metaboliz Hızı (BMR)";
            btnBMH.UseVisualStyleBackColor = false;
            btnBMH.Click += btnBMH_Click;
            // 
            // pnlHesaplamalar1
            // 
            pnlHesaplamalar1.BackColor = Color.FromArgb(244, 240, 232);
            pnlHesaplamalar1.Controls.Add(btnMKAH);
            pnlHesaplamalar1.Controls.Add(btnVKE);
            pnlHesaplamalar1.Controls.Add(btnGSI);
            pnlHesaplamalar1.Controls.Add(btnBMH);
            pnlHesaplamalar1.Controls.Add(btnIdealKilo);
            pnlHesaplamalar1.Controls.Add(btnVYO);
            pnlHesaplamalar1.Controls.Add(btnGKİ);
            pnlHesaplamalar1.Controls.Add(btnYVK);
            pnlHesaplamalar1.Dock = DockStyle.Left;
            pnlHesaplamalar1.Location = new Point(0, 0);
            pnlHesaplamalar1.Name = "pnlHesaplamalar1";
            pnlHesaplamalar1.Size = new Size(232, 607);
            pnlHesaplamalar1.TabIndex = 8;
            // 
            // btnMKAH
            // 
            btnMKAH.BackColor = Color.FromArgb(15, 194, 192);
            btnMKAH.FlatAppearance.BorderSize = 0;
            btnMKAH.FlatStyle = FlatStyle.Flat;
            btnMKAH.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMKAH.ForeColor = Color.White;
            btnMKAH.Image = (Image)resources.GetObject("btnMKAH.Image");
            btnMKAH.ImageAlign = ContentAlignment.MiddleLeft;
            btnMKAH.Location = new Point(-3, 539);
            btnMKAH.Name = "btnMKAH";
            btnMKAH.Size = new Size(230, 41);
            btnMKAH.TabIndex = 14;
            btnMKAH.Text = "        Maksimum Kalp Hızı";
            btnMKAH.UseVisualStyleBackColor = false;
            btnMKAH.Click += btnMKAH_Click;
            // 
            // btnGSI
            // 
            btnGSI.BackColor = Color.FromArgb(15, 194, 192);
            btnGSI.FlatAppearance.BorderSize = 0;
            btnGSI.FlatStyle = FlatStyle.Flat;
            btnGSI.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGSI.ForeColor = Color.White;
            btnGSI.Image = (Image)resources.GetObject("btnGSI.Image");
            btnGSI.ImageAlign = ContentAlignment.MiddleLeft;
            btnGSI.Location = new Point(-3, 469);
            btnGSI.Name = "btnGSI";
            btnGSI.Size = new Size(230, 41);
            btnGSI.TabIndex = 13;
            btnGSI.Text = "        Günlük Su İhtiyacı";
            btnGSI.UseVisualStyleBackColor = false;
            btnGSI.Click += btnGSI_Click;
            // 
            // btnIdealKilo
            // 
            btnIdealKilo.BackColor = Color.FromArgb(15, 194, 192);
            btnIdealKilo.FlatAppearance.BorderSize = 0;
            btnIdealKilo.FlatStyle = FlatStyle.Flat;
            btnIdealKilo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIdealKilo.ForeColor = Color.White;
            btnIdealKilo.Image = (Image)resources.GetObject("btnIdealKilo.Image");
            btnIdealKilo.ImageAlign = ContentAlignment.MiddleLeft;
            btnIdealKilo.Location = new Point(0, 390);
            btnIdealKilo.Name = "btnIdealKilo";
            btnIdealKilo.Size = new Size(230, 41);
            btnIdealKilo.TabIndex = 12;
            btnIdealKilo.Text = "        İdeal Kilo";
            btnIdealKilo.UseVisualStyleBackColor = false;
            btnIdealKilo.Click += btnIdealKilo_Click;
            // 
            // btnVYO
            // 
            btnVYO.BackColor = Color.FromArgb(15, 194, 192);
            btnVYO.FlatAppearance.BorderSize = 0;
            btnVYO.FlatStyle = FlatStyle.Flat;
            btnVYO.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVYO.ForeColor = Color.White;
            btnVYO.Image = (Image)resources.GetObject("btnVYO.Image");
            btnVYO.ImageAlign = ContentAlignment.MiddleLeft;
            btnVYO.Location = new Point(-1, 180);
            btnVYO.Name = "btnVYO";
            btnVYO.Size = new Size(230, 41);
            btnVYO.TabIndex = 9;
            btnVYO.Text = "Vücut Yağ Oranı";
            btnVYO.UseVisualStyleBackColor = false;
            btnVYO.Click += btnVYO_Click;
            // 
            // btnGKİ
            // 
            btnGKİ.BackColor = Color.FromArgb(15, 194, 192);
            btnGKİ.FlatAppearance.BorderSize = 0;
            btnGKİ.FlatStyle = FlatStyle.Flat;
            btnGKİ.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGKİ.ForeColor = Color.White;
            btnGKİ.Image = (Image)resources.GetObject("btnGKİ.Image");
            btnGKİ.ImageAlign = ContentAlignment.MiddleLeft;
            btnGKİ.Location = new Point(0, 317);
            btnGKİ.Name = "btnGKİ";
            btnGKİ.Size = new Size(230, 41);
            btnGKİ.TabIndex = 11;
            btnGKİ.Text = "        Günlük Kalori İhtiyacı";
            btnGKİ.UseVisualStyleBackColor = false;
            btnGKİ.Click += btnGKİ_Click;
            // 
            // btnYVK
            // 
            btnYVK.BackColor = Color.FromArgb(15, 194, 192);
            btnYVK.FlatAppearance.BorderSize = 0;
            btnYVK.FlatStyle = FlatStyle.Flat;
            btnYVK.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnYVK.ForeColor = Color.White;
            btnYVK.Image = (Image)resources.GetObject("btnYVK.Image");
            btnYVK.ImageAlign = ContentAlignment.MiddleLeft;
            btnYVK.Location = new Point(0, 250);
            btnYVK.Name = "btnYVK";
            btnYVK.Size = new Size(230, 41);
            btnYVK.TabIndex = 10;
            btnYVK.Text = "        Yağsız Vücut Kitlesi (FFMI)";
            btnYVK.UseVisualStyleBackColor = false;
            // 
            // pnlHesaplamalar2
            // 
            pnlHesaplamalar2.Location = new Point(238, 12);
            pnlHesaplamalar2.Name = "pnlHesaplamalar2";
            pnlHesaplamalar2.Size = new Size(818, 583);
            pnlHesaplamalar2.TabIndex = 9;
            // 
            // FormHesaplamalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 607);
            Controls.Add(pnlHesaplamalar2);
            Controls.Add(pnlHesaplamalar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHesaplamalar";
            Text = "FormHesaplamalar";
            Load += FormHesaplamalar_Load;
            pnlHesaplamalar1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnVKE;
        private Button btnBMH;
        private Panel pnlHesaplamalar1;
        private Button btnGSI;
        private Button btnIdealKilo;
        private Button btnVYO;
        private Button btnGKİ;
        private Button btnYVK;
        private Button btnMKAH;
        private Panel pnlHesaplamalar2;
    }
}