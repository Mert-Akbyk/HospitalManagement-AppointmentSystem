namespace HospitalManagement_AppointmentSystem
{
    partial class FrmPatientLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MskIDP = new MaskedTextBox();
            TxtPwP = new TextBox();
            lnkSignP = new LinkLabel();
            BtnLoginP = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(342, 71);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.2F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(48, 112);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 1;
            label2.Text = "T.C. Kimlik Nu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(109, 170);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 2;
            label3.Text = "Şifre :";
            // 
            // MskIDP
            // 
            MskIDP.Location = new Point(161, 110);
            MskIDP.Mask = "00000000000";
            MskIDP.Name = "MskIDP";
            MskIDP.Size = new Size(155, 27);
            MskIDP.TabIndex = 1;
            MskIDP.ValidatingType = typeof(int);
            // 
            // TxtPwP
            // 
            TxtPwP.Location = new Point(161, 168);
            TxtPwP.Name = "TxtPwP";
            TxtPwP.Size = new Size(155, 27);
            TxtPwP.TabIndex = 2;
            TxtPwP.UseSystemPasswordChar = true;
            // 
            // lnkSignP
            // 
            lnkSignP.ActiveLinkColor = Color.Red;
            lnkSignP.AutoSize = true;
            lnkSignP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lnkSignP.LinkColor = Color.Red;
            lnkSignP.Location = new Point(207, 258);
            lnkSignP.Name = "lnkSignP";
            lnkSignP.Size = new Size(62, 20);
            lnkSignP.TabIndex = 4;
            lnkSignP.TabStop = true;
            lnkSignP.Text = "Kayıt Ol";
            lnkSignP.LinkClicked += lnkSignP_LinkClicked;
            // 
            // BtnLoginP
            // 
            BtnLoginP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnLoginP.Location = new Point(178, 213);
            BtnLoginP.Name = "BtnLoginP";
            BtnLoginP.Size = new Size(116, 29);
            BtnLoginP.TabIndex = 3;
            BtnLoginP.Text = "Giriş Yap";
            BtnLoginP.UseVisualStyleBackColor = true;
            BtnLoginP.Click += BtnLoginP_Click;
            // 
            // FrmPatientLogin
            // 
            AcceptButton = BtnLoginP;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(365, 299);
            Controls.Add(BtnLoginP);
            Controls.Add(lnkSignP);
            Controls.Add(TxtPwP);
            Controls.Add(MskIDP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPatientLogin";
            Text = "Hasta Giriş Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox MskIDP;
        private TextBox TxtPwP;
        private LinkLabel lnkSignP;
        private Button BtnLoginP;
    }
}