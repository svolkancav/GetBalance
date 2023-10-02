namespace GetBalance.UI
{
    partial class FormKalpAtısHizi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKalpAtısHizi));
            panel1 = new Panel();
            lblHedefKalpHizi = new Label();
            label5 = new Label();
            lblMaxKalpAtisi = new Label();
            label4 = new Label();
            btnHesapla = new Button();
            txtYas = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbxAntremanSeviyesi = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHedefKalpHizi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblMaxKalpAtisi);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(435, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 236);
            panel1.TabIndex = 15;
            // 
            // lblHedefKalpHizi
            // 
            lblHedefKalpHizi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHedefKalpHizi.Location = new Point(3, 167);
            lblHedefKalpHizi.Name = "lblHedefKalpHizi";
            lblHedefKalpHizi.Size = new Size(281, 21);
            lblHedefKalpHizi.TabIndex = 4;
            lblHedefKalpHizi.Text = "0";
            lblHedefKalpHizi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 119);
            label5.Name = "label5";
            label5.Size = new Size(281, 25);
            label5.TabIndex = 3;
            label5.Text = "Hedef Kalp Atış Hızı";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMaxKalpAtisi
            // 
            lblMaxKalpAtisi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaxKalpAtisi.Location = new Point(3, 75);
            lblMaxKalpAtisi.Name = "lblMaxKalpAtisi";
            lblMaxKalpAtisi.Size = new Size(281, 21);
            lblMaxKalpAtisi.TabIndex = 2;
            lblMaxKalpAtisi.Text = "0";
            lblMaxKalpAtisi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 27);
            label4.Name = "label4";
            label4.Size = new Size(281, 25);
            label4.TabIndex = 1;
            label4.Text = "Maksimum Kalp Atış Hızı";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(2, 53, 53);
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(133, 345);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(234, 49);
            btnHesapla.TabIndex = 13;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(133, 178);
            txtYas.Multiline = true;
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(234, 32);
            txtYas.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(133, 251);
            label3.Name = "label3";
            label3.Size = new Size(144, 21);
            label3.TabIndex = 10;
            label3.Text = "Antreman Seviyesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(133, 145);
            label2.Name = "label2";
            label2.Size = new Size(33, 21);
            label2.TabIndex = 9;
            label2.Text = "Yaş";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(331, 44);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 8;
            label1.Text = "KALP ATIŞ HIZI";
            // 
            // cmbxAntremanSeviyesi
            // 
            cmbxAntremanSeviyesi.FormattingEnabled = true;
            cmbxAntremanSeviyesi.Location = new Point(133, 285);
            cmbxAntremanSeviyesi.Name = "cmbxAntremanSeviyesi";
            cmbxAntremanSeviyesi.Size = new Size(234, 23);
            cmbxAntremanSeviyesi.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(632, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // FormKalpAtısHizi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 685);
            Controls.Add(pictureBox1);
            Controls.Add(cmbxAntremanSeviyesi);
            Controls.Add(panel1);
            Controls.Add(btnHesapla);
            Controls.Add(txtYas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKalpAtısHizi";
            Text = "FormKalpAtısHizi";
            Load += FormKalpAtısHizi_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHedefKalpHizi;
        private Label label5;
        private Label lblMaxKalpAtisi;
        private Label label4;
        private Button btnHesapla;
        private TextBox txtYas;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbxAntremanSeviyesi;
        private PictureBox pictureBox1;
    }
}