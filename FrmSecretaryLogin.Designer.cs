namespace HospitalManagement_AppointmentSystem
{
    partial class FrmSecretaryLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryLogin));
            BtnLoginS = new Button();
            TxtPwS = new TextBox();
            MskIdentityS = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnLoginS
            // 
            BtnLoginS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnLoginS.ForeColor = Color.Black;
            BtnLoginS.Location = new Point(192, 195);
            BtnLoginS.Name = "BtnLoginS";
            BtnLoginS.Size = new Size(116, 29);
            BtnLoginS.TabIndex = 18;
            BtnLoginS.Text = "Giriş Yap";
            BtnLoginS.UseVisualStyleBackColor = true;
            BtnLoginS.Click += BtnLoginS_Click;
            // 
            // TxtPwS
            // 
            TxtPwS.Location = new Point(173, 151);
            TxtPwS.Name = "TxtPwS";
            TxtPwS.Size = new Size(155, 27);
            TxtPwS.TabIndex = 17;
            TxtPwS.UseSystemPasswordChar = true;
            // 
            // MskIdentityS
            // 
            MskIdentityS.Location = new Point(173, 93);
            MskIdentityS.Mask = "00000000000";
            MskIdentityS.Name = "MskIdentityS";
            MskIdentityS.Size = new Size(155, 27);
            MskIdentityS.TabIndex = 16;
            MskIdentityS.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(121, 153);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 15;
            label3.Text = "Şifre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.2F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(60, 95);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 14;
            label2.Text = "T.C. Kimlik Nu :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 71);
            label1.TabIndex = 13;
            label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSecretaryLogin
            // 
            AcceptButton = BtnLoginS;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(417, 249);
            Controls.Add(BtnLoginS);
            Controls.Add(TxtPwS);
            Controls.Add(MskIdentityS);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSecretaryLogin";
            Text = "FrmSecretary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLoginS;
        private TextBox TxtPwS;
        private MaskedTextBox MskIdentityS;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}