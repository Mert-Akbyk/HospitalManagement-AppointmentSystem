namespace HospitalManagement_AppointmentSystem
{
    partial class FrmPatientSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientSignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtNameP = new TextBox();
            TxtSurnameP = new TextBox();
            MskIDP = new MaskedTextBox();
            MskTelP = new MaskedTextBox();
            TxtPwP = new TextBox();
            CmbGenderP = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10.2F);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(109, 83);
            label1.Name = "label1";
            label1.Size = new Size(39, 21);
            label1.TabIndex = 0;
            label1.Text = "Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.2F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(83, 116);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(41, 149);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik Nu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 10.2F);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(70, 182);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefonu :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 10.2F);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(98, 252);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 4;
            label5.Text = "Şifre :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 10.2F);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(74, 215);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 5;
            label6.Text = "Cinsiyet :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Freestyle Script", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Aqua;
            label7.Location = new Point(29, 9);
            label7.Name = "label7";
            label7.Size = new Size(305, 59);
            label7.TabIndex = 6;
            label7.Text = "Hasta Kayıt Sistemi";
            // 
            // TxtNameP
            // 
            TxtNameP.Location = new Point(154, 81);
            TxtNameP.Name = "TxtNameP";
            TxtNameP.Size = new Size(159, 27);
            TxtNameP.TabIndex = 1;
            // 
            // TxtSurnameP
            // 
            TxtSurnameP.Location = new Point(154, 114);
            TxtSurnameP.Name = "TxtSurnameP";
            TxtSurnameP.Size = new Size(159, 27);
            TxtSurnameP.TabIndex = 2;
            // 
            // MskIDP
            // 
            MskIDP.Location = new Point(154, 147);
            MskIDP.Mask = "00000000000";
            MskIDP.Name = "MskIDP";
            MskIDP.Size = new Size(159, 27);
            MskIDP.TabIndex = 3;
            MskIDP.ValidatingType = typeof(int);
            // 
            // MskTelP
            // 
            MskTelP.Location = new Point(154, 180);
            MskTelP.Mask = "(999) 000-0000";
            MskTelP.Name = "MskTelP";
            MskTelP.Size = new Size(159, 27);
            MskTelP.TabIndex = 4;
            // 
            // TxtPwP
            // 
            TxtPwP.Location = new Point(154, 250);
            TxtPwP.Name = "TxtPwP";
            TxtPwP.Size = new Size(159, 27);
            TxtPwP.TabIndex = 6;
            // 
            // CmbGenderP
            // 
            CmbGenderP.FormattingEnabled = true;
            CmbGenderP.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CmbGenderP.Location = new Point(154, 213);
            CmbGenderP.Name = "CmbGenderP";
            CmbGenderP.Size = new Size(159, 28);
            CmbGenderP.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(185, 283);
            button1.Name = "button1";
            button1.Size = new Size(99, 35);
            button1.TabIndex = 7;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmPatientSignUp
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(358, 326);
            Controls.Add(button1);
            Controls.Add(CmbGenderP);
            Controls.Add(TxtPwP);
            Controls.Add(MskTelP);
            Controls.Add(MskIDP);
            Controls.Add(TxtSurnameP);
            Controls.Add(TxtNameP);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.No;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPatientSignUp";
            Text = "Hasta Kayıt Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtNameP;
        private TextBox TxtSurnameP;
        private MaskedTextBox MskIDP;
        private MaskedTextBox MskTelP;
        private TextBox TxtPwP;
        private ComboBox CmbGenderP;
        private Button button1;
    }
}