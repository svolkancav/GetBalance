namespace GetBalance.UI
{
    partial class FormAddFood
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
            panel1 = new Panel();
            btnYeniYemekEkle = new Button();
            btnOguneEkle = new Button();
            lsvFoods = new ListView();
            cmbKategoriler = new ComboBox();
            txtYemekAra = new TextBox();
            pbKapat = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbKapat).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnYeniYemekEkle);
            panel1.Controls.Add(btnOguneEkle);
            panel1.Controls.Add(lsvFoods);
            panel1.Controls.Add(cmbKategoriler);
            panel1.Controls.Add(txtYemekAra);
            panel1.Location = new Point(5, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 549);
            panel1.TabIndex = 0;
            // 
            // btnYeniYemekEkle
            // 
            btnYeniYemekEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnYeniYemekEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniYemekEkle.Location = new Point(236, 488);
            btnYeniYemekEkle.Name = "btnYeniYemekEkle";
            btnYeniYemekEkle.Size = new Size(201, 48);
            btnYeniYemekEkle.TabIndex = 3;
            btnYeniYemekEkle.Text = "YENİ YEMEK EKLE";
            btnYeniYemekEkle.UseVisualStyleBackColor = true;
            btnYeniYemekEkle.Click += btnYeniYemekEkle_Click;
            // 
            // btnOguneEkle
            // 
            btnOguneEkle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOguneEkle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOguneEkle.Location = new Point(14, 488);
            btnOguneEkle.Name = "btnOguneEkle";
            btnOguneEkle.Size = new Size(201, 48);
            btnOguneEkle.TabIndex = 3;
            btnOguneEkle.Text = "SEÇİLİ YEMEĞİ ÖĞÜNE EKLE";
            btnOguneEkle.UseVisualStyleBackColor = true;
            btnOguneEkle.Click += btnOguneEkle_Click;
            // 
            // lsvFoods
            // 
            lsvFoods.Location = new Point(14, 45);
            lsvFoods.Name = "lsvFoods";
            lsvFoods.Size = new Size(423, 437);
            lsvFoods.TabIndex = 2;
            lsvFoods.UseCompatibleStateImageBehavior = false;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(288, 12);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(149, 23);
            cmbKategoriler.TabIndex = 1;
            // 
            // txtYemekAra
            // 
            txtYemekAra.Location = new Point(14, 12);
            txtYemekAra.Name = "txtYemekAra";
            txtYemekAra.PlaceholderText = "Yemek Ara";
            txtYemekAra.Size = new Size(268, 23);
            txtYemekAra.TabIndex = 0;
            txtYemekAra.TextChanged += txtYemekAra_TextChanged;
            // 
            // pbKapat
            // 
            pbKapat.Cursor = Cursors.Hand;
            pbKapat.Image = Properties.Resources.close_window_32__1_;
            pbKapat.Location = new Point(420, 8);
            pbKapat.Name = "pbKapat";
            pbKapat.Size = new Size(32, 32);
            pbKapat.SizeMode = PictureBoxSizeMode.AutoSize;
            pbKapat.TabIndex = 4;
            pbKapat.TabStop = false;
            pbKapat.Click += pbKapat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 8);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 5;
            label1.Text = "YEMEKLER";
            // 
            // FormAddFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 53, 53);
            ClientSize = new Size(460, 600);
            Controls.Add(label1);
            Controls.Add(pbKapat);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddFood";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddFood";
            Load += FormAddFood_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbKapat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtYemekAra;
        private Button btnYeniYemekEkle;
        private Button btnOguneEkle;
        private ListView lsvFoods;
        private ComboBox cmbKategoriler;
        private PictureBox pbKapat;
        private Label label1;
    }
}