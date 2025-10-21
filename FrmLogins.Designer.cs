namespace HospitalManagement_AppointmentSystem
{
    partial class FrmLogins
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            BtnPatient = new Button();
            BtnDoctor = new Button();
            BtnSecretary = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnPatient
            // 
            BtnPatient.BackgroundImage = (Image)resources.GetObject("BtnPatient.BackgroundImage");
            BtnPatient.BackgroundImageLayout = ImageLayout.Stretch;
            BtnPatient.Location = new Point(12, 245);
            BtnPatient.Name = "BtnPatient";
            BtnPatient.Size = new Size(245, 155);
            BtnPatient.TabIndex = 0;
            BtnPatient.UseVisualStyleBackColor = true;
            BtnPatient.Click += BtnPatient_Click;
            // 
            // BtnDoctor
            // 
            BtnDoctor.BackgroundImage = (Image)resources.GetObject("BtnDoctor.BackgroundImage");
            BtnDoctor.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDoctor.Location = new Point(277, 245);
            BtnDoctor.Name = "BtnDoctor";
            BtnDoctor.Size = new Size(245, 155);
            BtnDoctor.TabIndex = 1;
            BtnDoctor.UseVisualStyleBackColor = true;
            BtnDoctor.Click += BtnDoctor_Click;
            // 
            // BtnSecretary
            // 
            BtnSecretary.BackgroundImage = (Image)resources.GetObject("BtnSecretary.BackgroundImage");
            BtnSecretary.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSecretary.Location = new Point(543, 245);
            BtnSecretary.Name = "BtnSecretary";
            BtnSecretary.Size = new Size(245, 155);
            BtnSecretary.TabIndex = 2;
            BtnSecretary.Text = " ";
            BtnSecretary.UseVisualStyleBackColor = true;
            BtnSecretary.Click += BtnSecretary_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(63, 70);
            label1.Name = "label1";
            label1.Size = new Size(373, 71);
            label1.TabIndex = 3;
            label1.Text = "Chansey HOSPITAL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(88, 403);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 5;
            label2.Text = "Hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(355, 403);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 6;
            label3.Text = "Doktor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(625, 403);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 7;
            label4.Text = "Sekreter";
            // 
            // FrmLogins
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(BtnSecretary);
            Controls.Add(BtnDoctor);
            Controls.Add(BtnPatient);
            ForeColor = Color.LightSlateGray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogins";
            Text = "Chansey Hastanesi Giriş Paneli";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnPatient;
        private Button BtnDoctor;
        private Button BtnSecretary;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
