namespace HospitalManagement_AppointmentSystem
{
    partial class FrmDoctorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorLogin));
            TxtPwD = new TextBox();
            MskIdentityDr = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnLoginDr = new Button();
            SuspendLayout();
            // 
            // TxtPwD
            // 
            TxtPwD.Location = new Point(156, 156);
            TxtPwD.Name = "TxtPwD";
            TxtPwD.Size = new Size(155, 27);
            TxtPwD.TabIndex = 2;
            TxtPwD.UseSystemPasswordChar = true;
            // 
            // MskIdentityDr
            // 
            MskIdentityDr.Location = new Point(156, 98);
            MskIdentityDr.Mask = "00000000000";
            MskIdentityDr.Name = "MskIdentityDr";
            MskIdentityDr.Size = new Size(155, 27);
            MskIdentityDr.TabIndex = 1;
            MskIdentityDr.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(104, 158);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 9;
            label3.Text = "Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.2F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(43, 100);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 8;
            label2.Text = "T.C. Kimlik Nu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(368, 71);
            label1.TabIndex = 7;
            label1.Text = "Doktor Giriş Paneli";
            // 
            // BtnLoginDr
            // 
            BtnLoginDr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnLoginDr.ForeColor = Color.Black;
            BtnLoginDr.Location = new Point(175, 200);
            BtnLoginDr.Name = "BtnLoginDr";
            BtnLoginDr.Size = new Size(116, 29);
            BtnLoginDr.TabIndex = 3;
            BtnLoginDr.Text = "Giriş Yap";
            BtnLoginDr.UseVisualStyleBackColor = true;
            BtnLoginDr.Click += BtnLoginP_Click;
            // 
            // FrmDoctorLogin
            // 
            AcceptButton = BtnLoginDr;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(381, 253);
            Controls.Add(BtnLoginDr);
            Controls.Add(TxtPwD);
            Controls.Add(MskIdentityDr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.LightSlateGray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDoctorLogin";
            Text = "Doktor Giriş Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtPwD;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnLoginDr;
        public MaskedTextBox MskIdentityDr;
    }
}