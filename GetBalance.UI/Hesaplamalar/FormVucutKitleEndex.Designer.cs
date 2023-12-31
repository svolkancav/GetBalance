﻿namespace GetBalance.UI
{
    partial class FormVucutKitleEndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVucutKitleEndex));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoy = new TextBox();
            txtKilo = new TextBox();
            btnHesapla = new Button();
            cpbVKI = new ReaLTaiizor.Controls.CircleProgressBar();
            panel1 = new Panel();
            lblYorum = new Label();
            lblVKIDeger = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 49);
            label1.Name = "label1";
            label1.Size = new Size(259, 25);
            label1.TabIndex = 0;
            label1.Text = "VÜCUT KİTLE İNDEKSİ  (BMI)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(186, 152);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 1;
            label2.Text = "Boyunuz (cm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(186, 244);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Kilonuz (kg)";
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(186, 185);
            txtBoy.Multiline = true;
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(234, 32);
            txtBoy.TabIndex = 3;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(186, 280);
            txtKilo.Multiline = true;
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(234, 32);
            txtKilo.TabIndex = 4;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.FromArgb(2, 53, 53);
            btnHesapla.FlatStyle = FlatStyle.Flat;
            btnHesapla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.ForeColor = Color.White;
            btnHesapla.Location = new Point(186, 352);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(234, 49);
            btnHesapla.TabIndex = 5;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // cpbVKI
            // 
            cpbVKI.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cpbVKI.Location = new Point(560, 167);
            cpbVKI.Maximum = 100L;
            cpbVKI.MinimumSize = new Size(100, 100);
            cpbVKI.Name = "cpbVKI";
            cpbVKI.PercentColor = Color.Cyan;
            cpbVKI.ProgressColor1 = Color.White;
            cpbVKI.ProgressColor2 = Color.Red;
            cpbVKI.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            cpbVKI.Size = new Size(130, 130);
            cpbVKI.TabIndex = 6;
            cpbVKI.Text = "circleProgressBar1";
            cpbVKI.Value = 0L;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblYorum);
            panel1.Controls.Add(lblVKIDeger);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(488, 303);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 152);
            panel1.TabIndex = 7;
            // 
            // lblYorum
            // 
            lblYorum.Location = new Point(3, 108);
            lblYorum.Name = "lblYorum";
            lblYorum.Size = new Size(288, 15);
            lblYorum.TabIndex = 3;
            lblYorum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVKIDeger
            // 
            lblVKIDeger.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVKIDeger.Location = new Point(3, 49);
            lblVKIDeger.Name = "lblVKIDeger";
            lblVKIDeger.Size = new Size(288, 21);
            lblVKIDeger.TabIndex = 2;
            lblVKIDeger.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(288, 25);
            label4.TabIndex = 1;
            label4.Text = "VÜCUT KİTLE İNDEKSİ  (BMI)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            // FormVucutKitleEndex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 685);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(cpbVKI);
            Controls.Add(btnHesapla);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormVucutKitleEndex";
            Text = "FormVucutKitleEndex";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoy;
        private TextBox txtKilo;
        private Button btnHesapla;
        private ReaLTaiizor.Controls.CircleProgressBar cpbVKI;
        private Panel panel1;
        private Label lblVKIDeger;
        private Label label4;
        private Label lblYorum;
        private PictureBox pictureBox1;
    }
}