namespace HospitalManagement_AppointmentSystem
{
    partial class FrmSecretaryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSecretaryDetails));
            groupBox1 = new GroupBox();
            LblSecretaryName = new Label();
            label3 = new Label();
            LblSecretaryID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnNotice = new Button();
            RchNotice = new RichTextBox();
            groupBox3 = new GroupBox();
            BtnUp = new Button();
            BtnSave = new Button();
            ChkInfo = new CheckBox();
            MskIdentity = new MaskedTextBox();
            CmbDr = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            CmbBranch = new ComboBox();
            MskOclock = new MaskedTextBox();
            MskDate = new MaskedTextBox();
            TxtID = new TextBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox5 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox6 = new GroupBox();
            button1 = new Button();
            BtnDateList = new Button();
            BtnBrPnl = new Button();
            BtnDrPnl = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblSecretaryName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblSecretaryID);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Aqua;
            groupBox1.Location = new Point(13, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(246, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgileri :";
            // 
            // LblSecretaryName
            // 
            LblSecretaryName.AutoSize = true;
            LblSecretaryName.Font = new Font("Impact", 10.2F);
            LblSecretaryName.ForeColor = Color.Aqua;
            LblSecretaryName.Location = new Point(123, 72);
            LblSecretaryName.Margin = new Padding(4, 0, 4, 0);
            LblSecretaryName.Name = "LblSecretaryName";
            LblSecretaryName.Size = new Size(69, 21);
            LblSecretaryName.TabIndex = 3;
            LblSecretaryName.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(24, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 2;
            label3.Text = "Adı Soyadı :";
            // 
            // LblSecretaryID
            // 
            LblSecretaryID.AutoSize = true;
            LblSecretaryID.Font = new Font("Impact", 10.2F);
            LblSecretaryID.ForeColor = Color.Aqua;
            LblSecretaryID.Location = new Point(123, 34);
            LblSecretaryID.Margin = new Padding(4, 0, 4, 0);
            LblSecretaryID.Name = "LblSecretaryID";
            LblSecretaryID.Size = new Size(109, 21);
            LblSecretaryID.TabIndex = 1;
            LblSecretaryID.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10.2F);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(8, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "T.C. Kimlik Nu :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnNotice);
            groupBox2.Controls.Add(RchNotice);
            groupBox2.ForeColor = Color.Aqua;
            groupBox2.Location = new Point(13, 130);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(246, 243);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur :";
            // 
            // BtnNotice
            // 
            BtnNotice.BackColor = SystemColors.ButtonHighlight;
            BtnNotice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnNotice.ForeColor = Color.Black;
            BtnNotice.Location = new Point(68, 183);
            BtnNotice.Name = "BtnNotice";
            BtnNotice.Size = new Size(99, 35);
            BtnNotice.TabIndex = 34;
            BtnNotice.Text = "Oluştur";
            BtnNotice.UseVisualStyleBackColor = false;
            BtnNotice.Click += BtnNotice_Click;
            // 
            // RchNotice
            // 
            RchNotice.Location = new Point(7, 26);
            RchNotice.Name = "RchNotice";
            RchNotice.Size = new Size(232, 151);
            RchNotice.TabIndex = 0;
            RchNotice.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnUp);
            groupBox3.Controls.Add(BtnSave);
            groupBox3.Controls.Add(ChkInfo);
            groupBox3.Controls.Add(MskIdentity);
            groupBox3.Controls.Add(CmbDr);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(CmbBranch);
            groupBox3.Controls.Add(MskOclock);
            groupBox3.Controls.Add(MskDate);
            groupBox3.Controls.Add(TxtID);
            groupBox3.Controls.Add(label6);
            groupBox3.ForeColor = Color.Aqua;
            groupBox3.Location = new Point(267, 12);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(246, 361);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevular :";
//            groupBox3.Enter += groupBox3_Enter;
            // 
            // BtnUp
            // 
            BtnUp.BackColor = SystemColors.ButtonHighlight;
            BtnUp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnUp.ForeColor = Color.Black;
            BtnUp.Location = new Point(115, 301);
            BtnUp.Name = "BtnUp";
            BtnUp.Size = new Size(99, 35);
            BtnUp.TabIndex = 36;
            BtnUp.Text = "Güncelle";
            BtnUp.UseVisualStyleBackColor = false;
            BtnUp.Click += BtnUp_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = SystemColors.ButtonHighlight;
            BtnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnSave.ForeColor = Color.Black;
            BtnSave.Location = new Point(115, 260);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(99, 35);
            BtnSave.TabIndex = 35;
            BtnSave.Text = "Kaydet";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // ChkInfo
            // 
            ChkInfo.AutoSize = true;
            ChkInfo.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ChkInfo.Location = new Point(125, 229);
            ChkInfo.Name = "ChkInfo";
            ChkInfo.Size = new Size(78, 25);
            ChkInfo.TabIndex = 14;
            ChkInfo.Text = "Durum";
            ChkInfo.UseVisualStyleBackColor = true;
            // 
            // MskIdentity
            // 
            MskIdentity.Location = new Point(103, 196);
            MskIdentity.Mask = "00000000000";
            MskIdentity.Name = "MskIdentity";
            MskIdentity.Size = new Size(125, 27);
            MskIdentity.TabIndex = 13;
            MskIdentity.ValidatingType = typeof(int);
            // 
            // CmbDr
            // 
            CmbDr.FormattingEnabled = true;
            CmbDr.Location = new Point(103, 161);
            CmbDr.Name = "CmbDr";
            CmbDr.Size = new Size(125, 28);
            CmbDr.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 10.2F);
            label7.ForeColor = Color.Aqua;
            label7.Location = new Point(25, 163);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(62, 21);
            label7.TabIndex = 5;
            label7.Text = "Doktor :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 10.2F);
            label8.ForeColor = Color.Aqua;
            label8.Location = new Point(49, 198);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(38, 21);
            label8.TabIndex = 6;
            label8.Text = "T.C. :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 10.2F);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(30, 129);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 4;
            label5.Text = "Branş :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.2F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(39, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 3;
            label2.Text = "Saat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 10.2F);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(35, 63);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 2;
            label4.Text = "Tarih :";
            // 
            // CmbBranch
            // 
            CmbBranch.FormattingEnabled = true;
            CmbBranch.Location = new Point(103, 127);
            CmbBranch.Name = "CmbBranch";
            CmbBranch.Size = new Size(125, 28);
            CmbBranch.TabIndex = 11;
            CmbBranch.SelectedIndexChanged += CmbBranch_SelectedIndexChanged;
            // 
            // MskOclock
            // 
            MskOclock.Location = new Point(103, 94);
            MskOclock.Mask = "00:00";
            MskOclock.Name = "MskOclock";
            MskOclock.Size = new Size(125, 27);
            MskOclock.TabIndex = 10;
            MskOclock.ValidatingType = typeof(DateTime);
            // 
            // MskDate
            // 
            MskDate.Location = new Point(103, 61);
            MskDate.Mask = "00/00/0000";
            MskDate.Name = "MskDate";
            MskDate.Size = new Size(125, 27);
            MskDate.TabIndex = 9;
            MskDate.ValidatingType = typeof(DateTime);
            // 
            // TxtID
            // 
            TxtID.Location = new Point(103, 28);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(125, 27);
            TxtID.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 10.2F);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(57, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(30, 21);
            label6.TabIndex = 0;
            label6.Text = "ID :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.ForeColor = Color.Aqua;
            groupBox4.Location = new Point(521, 12);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(412, 170);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(404, 144);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView2);
            groupBox5.ForeColor = Color.Aqua;
            groupBox5.Location = new Point(521, 188);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(412, 185);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktorlar :";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(4, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(404, 159);
            dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(BtnDateList);
            groupBox6.Controls.Add(BtnBrPnl);
            groupBox6.Controls.Add(BtnDrPnl);
            groupBox6.ForeColor = Color.Aqua;
            groupBox6.Location = new Point(112, 379);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(754, 60);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hızlı Erişim Paneli :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(592, 21);
            button1.Name = "button1";
            button1.Size = new Size(156, 33);
            button1.TabIndex = 39;
            button1.Text = "Duyuru Paneli";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnDateList
            // 
            BtnDateList.BackColor = SystemColors.ButtonHighlight;
            BtnDateList.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnDateList.ForeColor = Color.Black;
            BtnDateList.Location = new Point(400, 21);
            BtnDateList.Name = "BtnDateList";
            BtnDateList.Size = new Size(156, 33);
            BtnDateList.TabIndex = 38;
            BtnDateList.Text = "Randevu Listesi";
            BtnDateList.UseVisualStyleBackColor = false;
            BtnDateList.Click += BtnDateList_Click;
            // 
            // BtnBrPnl
            // 
            BtnBrPnl.BackColor = SystemColors.ButtonHighlight;
            BtnBrPnl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnBrPnl.ForeColor = Color.Black;
            BtnBrPnl.Location = new Point(212, 21);
            BtnBrPnl.Name = "BtnBrPnl";
            BtnBrPnl.Size = new Size(156, 33);
            BtnBrPnl.TabIndex = 37;
            BtnBrPnl.Text = "Branş Paneli";
            BtnBrPnl.UseVisualStyleBackColor = false;
            BtnBrPnl.Click += BtnBrPnl_Click;
            // 
            // BtnDrPnl
            // 
            BtnDrPnl.BackColor = SystemColors.ButtonHighlight;
            BtnDrPnl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnDrPnl.ForeColor = Color.Black;
            BtnDrPnl.Location = new Point(20, 21);
            BtnDrPnl.Name = "BtnDrPnl";
            BtnDrPnl.Size = new Size(156, 33);
            BtnDrPnl.TabIndex = 36;
            BtnDrPnl.Text = "Doktor Paneli";
            BtnDrPnl.UseVisualStyleBackColor = false;
            BtnDrPnl.Click += BtnDrPnl_Click;
            // 
            // FrmSecretaryDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(948, 450);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmSecretaryDetails";
            Text = "FrmSecretaryDetails";
            Load += FrmSecretaryDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblSecretaryName;
        private Label label3;
        private Label LblSecretaryID;
        private Label label1;
        private GroupBox groupBox2;
        private RichTextBox RchNotice;
        internal Button BtnNotice;
        private GroupBox groupBox3;
        private Label label7;
        private Label label5;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label8;
        internal Button BtnUp;
        internal Button BtnSave;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox5;
        private DataGridView dataGridView2;
        private GroupBox groupBox6;
        internal Button BtnDateList;
        internal Button BtnBrPnl;
        internal Button BtnDrPnl;
        public CheckBox ChkInfo;
        public MaskedTextBox MskIdentity;
        public ComboBox CmbDr;
        public ComboBox CmbBranch;
        public MaskedTextBox MskOclock;
        public MaskedTextBox MskDate;
        public TextBox TxtID;
        internal Button button1;
    }
}