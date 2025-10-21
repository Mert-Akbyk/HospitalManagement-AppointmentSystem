namespace HospitalManagement_AppointmentSystem
{
    partial class FrmDoctorInfoEditing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorInfoEditing));
            MskIDDr = new MaskedTextBox();
            TxtSurnameDr = new TextBox();
            TxtNameDr = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtPwDr = new TextBox();
            label5 = new Label();
            CmbBrancDr = new ComboBox();
            label4 = new Label();
            BrnUpD = new Button();
            label7 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // MskIDDr
            // 
            MskIDDr.Location = new Point(143, 230);
            MskIDDr.Mask = "00000000000";
            MskIDDr.Name = "MskIDDr";
            MskIDDr.Size = new Size(159, 27);
            MskIDDr.TabIndex = 28;
            MskIDDr.ValidatingType = typeof(int);
            // 
            // TxtSurnameDr
            // 
            TxtSurnameDr.Location = new Point(143, 197);
            TxtSurnameDr.Name = "TxtSurnameDr";
            TxtSurnameDr.Size = new Size(159, 27);
            TxtSurnameDr.TabIndex = 27;
            // 
            // TxtNameDr
            // 
            TxtNameDr.Location = new Point(143, 164);
            TxtNameDr.Name = "TxtNameDr";
            TxtNameDr.Size = new Size(159, 27);
            TxtNameDr.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(30, 235);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 25;
            label3.Text = "T.C. Kimlik Nu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.2F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(72, 202);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 24;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10.2F);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(98, 166);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 23;
            label1.Text = "Adı :";
            // 
            // TxtPwDr
            // 
            TxtPwDr.Location = new Point(143, 297);
            TxtPwDr.Name = "TxtPwDr";
            TxtPwDr.Size = new Size(159, 27);
            TxtPwDr.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 10.2F);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(87, 299);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 29;
            label5.Text = "Şifre :";
            // 
            // CmbBrancDr
            // 
            CmbBrancDr.FormattingEnabled = true;
            CmbBrancDr.Location = new Point(143, 263);
            CmbBrancDr.Name = "CmbBrancDr";
            CmbBrancDr.Size = new Size(159, 28);
            CmbBrancDr.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 10.2F);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(80, 270);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 32;
            label4.Text = "Branş :";
            // 
            // BrnUpD
            // 
            BrnUpD.BackColor = SystemColors.ButtonHighlight;
            BrnUpD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BrnUpD.Location = new Point(172, 330);
            BrnUpD.Name = "BrnUpD";
            BrnUpD.Size = new Size(99, 35);
            BrnUpD.TabIndex = 33;
            BrnUpD.Text = "Güncelle";
            BrnUpD.UseVisualStyleBackColor = false;
            BrnUpD.Click += BrnUpD_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Freestyle Script", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Aqua;
            label7.Location = new Point(23, 32);
            label7.Name = "label7";
            label7.Size = new Size(365, 59);
            label7.TabIndex = 34;
            label7.Text = "Doktor Bilgi Güncelleme";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Freestyle Script", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(128, 91);
            label6.Name = "label6";
            label6.Size = new Size(121, 59);
            label6.TabIndex = 35;
            label6.Text = "Sistemi";
            // 
            // FrmDoctorInfoEditing
            // 
            AcceptButton = BrnUpD;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(402, 395);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(BrnUpD);
            Controls.Add(label4);
            Controls.Add(CmbBrancDr);
            Controls.Add(TxtPwDr);
            Controls.Add(label5);
            Controls.Add(MskIDDr);
            Controls.Add(TxtSurnameDr);
            Controls.Add(TxtNameDr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDoctorInfoEditing";
            Text = "FrmDoctorInfoEditing";
            Load += FrmDoctorInfoEditing_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox MskIDDr;
        private TextBox TxtSurnameDr;
        private TextBox TxtNameDr;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtPwDr;
        private Label label5;
        private ComboBox CmbBrancDr;
        private Label label4;
        internal Button BrnUpD;
        private Label label7;
        private Label label6;
    }
}