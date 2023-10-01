namespace GetBalance.UI
{
    partial class FormHatirlatici
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHatirlatici));
            timer1 = new System.Windows.Forms.Timer(components);
            btnAlarmKur = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnStop = new Button();
            lblDurum = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAlarmKur
            // 
            btnAlarmKur.BackColor = Color.FromArgb(15, 194, 192);
            btnAlarmKur.ForeColor = Color.White;
            btnAlarmKur.Image = (Image)resources.GetObject("btnAlarmKur.Image");
            btnAlarmKur.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlarmKur.Location = new Point(221, 137);
            btnAlarmKur.Name = "btnAlarmKur";
            btnAlarmKur.Size = new Size(138, 43);
            btnAlarmKur.TabIndex = 0;
            btnAlarmKur.Text = "     Alarm Kur";
            btnAlarmKur.UseVisualStyleBackColor = false;
            btnAlarmKur.Click += btnAlarmKur_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 30);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 2;
            label1.Text = "Lütfen Saati Giriniz";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(200, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(189, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Red;
            btnStop.ForeColor = Color.White;
            btnStop.Image = (Image)resources.GetObject("btnStop.Image");
            btnStop.ImageAlign = ContentAlignment.MiddleLeft;
            btnStop.Location = new Point(221, 186);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(138, 38);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblDurum.Location = new Point(265, 111);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(50, 17);
            lblDurum.TabIndex = 5;
            lblDurum.Text = "Durum";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(483, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormHatirlatici
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 259);
            Controls.Add(pictureBox1);
            Controls.Add(lblDurum);
            Controls.Add(btnStop);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(btnAlarmKur);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHatirlatici";
            Text = "FormHatirlatici";
            Load += FormHatirlatici_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btnAlarmKur;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnStop;
        private Label lblDurum;
        private PictureBox pictureBox1;
    }
}