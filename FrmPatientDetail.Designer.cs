namespace HospitalManagement_AppointmentSystem
{
    partial class FrmPatientDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPatientDetail));
            groupBox1 = new GroupBox();
            LnkChangeInfo = new LinkLabel();
            LblPatientInfo = new Label();
            LblIdentity = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TxtID = new TextBox();
            label3 = new Label();
            BtnMakeApp = new Button();
            RchComplaint = new RichTextBox();
            CmbDoctorInfo = new ComboBox();
            CmbBranch = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox5 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LnkChangeInfo);
            groupBox1.Controls.Add(LblPatientInfo);
            groupBox1.Controls.Add(LblIdentity);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Aqua;
            groupBox1.Location = new Point(14, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(506, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri :";
            // 
            // LnkChangeInfo
            // 
            LnkChangeInfo.AutoSize = true;
            LnkChangeInfo.Location = new Point(145, 102);
            LnkChangeInfo.Name = "LnkChangeInfo";
            LnkChangeInfo.Size = new Size(146, 23);
            LnkChangeInfo.TabIndex = 4;
            LnkChangeInfo.TabStop = true;
            LnkChangeInfo.Text = "Bilgilerini Düzenle";
            LnkChangeInfo.LinkClicked += LnkChangeInfo_LinkClicked;
            // 
            // LblPatientInfo
            // 
            LblPatientInfo.AutoSize = true;
            LblPatientInfo.Font = new Font("Impact", 10.2F);
            LblPatientInfo.ForeColor = Color.Aqua;
            LblPatientInfo.Location = new Point(237, 62);
            LblPatientInfo.Name = "LblPatientInfo";
            LblPatientInfo.Size = new Size(69, 21);
            LblPatientInfo.TabIndex = 3;
            LblPatientInfo.Text = "Null Null";
            // 
            // LblIdentity
            // 
            LblIdentity.AutoSize = true;
            LblIdentity.Font = new Font("Impact", 10.2F);
            LblIdentity.ForeColor = Color.Aqua;
            LblIdentity.Location = new Point(237, 26);
            LblIdentity.Name = "LblIdentity";
            LblIdentity.Size = new Size(109, 21);
            LblIdentity.TabIndex = 2;
            LblIdentity.Text = "00000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.2F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(136, 62);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Adı Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSlateGray;
            label1.Font = new Font("Impact", 10.2F);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(115, 26);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "T.C. Kimlik Nu :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(TxtID);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(BtnMakeApp);
            groupBox2.Controls.Add(RchComplaint);
            groupBox2.Controls.Add(CmbDoctorInfo);
            groupBox2.Controls.Add(CmbBranch);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.Aqua;
            groupBox2.Location = new Point(14, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 329);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Sistemi :";
            // 
            // TxtID
            // 
            TxtID.Enabled = false;
            TxtID.Location = new Point(136, 34);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(309, 30);
            TxtID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(103, 38);
            label3.Name = "label3";
            label3.Size = new Size(27, 21);
            label3.TabIndex = 8;
            label3.Text = "ID:";
            // 
            // BtnMakeApp
            // 
            BtnMakeApp.ForeColor = Color.Black;
            BtnMakeApp.Location = new Point(162, 286);
            BtnMakeApp.Name = "BtnMakeApp";
            BtnMakeApp.Size = new Size(106, 33);
            BtnMakeApp.TabIndex = 7;
            BtnMakeApp.Text = "Randevu Al";
            BtnMakeApp.UseVisualStyleBackColor = true;
            BtnMakeApp.Click += BtnMakeApp_Click;
            // 
            // RchComplaint
            // 
            RchComplaint.Location = new Point(136, 143);
            RchComplaint.Name = "RchComplaint";
            RchComplaint.Size = new Size(309, 137);
            RchComplaint.TabIndex = 6;
            RchComplaint.Text = "";
            // 
            // CmbDoctorInfo
            // 
            CmbDoctorInfo.FormattingEnabled = true;
            CmbDoctorInfo.Location = new Point(136, 106);
            CmbDoctorInfo.Name = "CmbDoctorInfo";
            CmbDoctorInfo.Size = new Size(309, 31);
            CmbDoctorInfo.TabIndex = 5;
            CmbDoctorInfo.SelectedIndexChanged += CmbDoctorInfo_SelectedIndexChanged;
            // 
            // CmbBranch
            // 
            CmbBranch.FormattingEnabled = true;
            CmbBranch.Location = new Point(136, 69);
            CmbBranch.Name = "CmbBranch";
            CmbBranch.Size = new Size(309, 31);
            CmbBranch.TabIndex = 4;
            CmbBranch.SelectedIndexChanged += CmbBranch_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 10.2F);
            label7.ForeColor = Color.Aqua;
            label7.Location = new Point(61, 147);
            label7.Name = "label7";
            label7.Size = new Size(69, 21);
            label7.TabIndex = 3;
            label7.Text = "Şikayet :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 10.2F);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(42, 110);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 2;
            label6.Text = "Doktor Adı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 10.2F);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(73, 73);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 1;
            label5.Text = "Branş :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.Aqua;
            groupBox3.Location = new Point(526, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(524, 220);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Geçmiş Randevular :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(518, 191);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.Aqua;
            groupBox4.Location = new Point(526, 238);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(524, 255);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular :";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 26);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(518, 226);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(1062, 154);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(10, 10);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(303, 286);
            button1.Name = "button1";
            button1.Size = new Size(106, 33);
            button1.TabIndex = 10;
            button1.Text = "Çıkış";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmPatientDetail
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1058, 497);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmPatientDetail";
            Text = "Hasta Detayları Paneli";
            Load += FrmPatientDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblIdentity;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label LblPatientInfo;
        private RichTextBox RchComplaint;
        private ComboBox CmbDoctorInfo;
        private ComboBox CmbBranch;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button BtnMakeApp;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private LinkLabel LnkChangeInfo;
        private GroupBox groupBox5;
        private TextBox TxtID;
        private Label label3;
        private Button button1;
    }
}