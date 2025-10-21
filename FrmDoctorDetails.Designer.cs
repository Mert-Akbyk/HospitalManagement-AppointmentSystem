namespace HospitalManagement_AppointmentSystem
{
    partial class FrmDoctorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorDetails));
            groupBox1 = new GroupBox();
            LblDrName = new Label();
            label3 = new Label();
            LblDrID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            RchComplaint = new RichTextBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            BtnExit = new Button();
            BtnNotice = new Button();
            BtnUpgrade = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblDrName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblDrID);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Aqua;
            groupBox1.Location = new Point(15, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(361, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bilgileri :";
            // 
            // LblDrName
            // 
            LblDrName.AutoSize = true;
            LblDrName.Font = new Font("Impact", 10.2F);
            LblDrName.ForeColor = Color.Aqua;
            LblDrName.Location = new Point(202, 77);
            LblDrName.Margin = new Padding(4, 0, 4, 0);
            LblDrName.Name = "LblDrName";
            LblDrName.Size = new Size(69, 21);
            LblDrName.TabIndex = 3;
            LblDrName.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(103, 77);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 2;
            label3.Text = "Adı Soyadı :";
            // 
            // LblDrID
            // 
            LblDrID.AutoSize = true;
            LblDrID.Font = new Font("Impact", 10.2F);
            LblDrID.ForeColor = Color.Aqua;
            LblDrID.Location = new Point(202, 39);
            LblDrID.Margin = new Padding(4, 0, 4, 0);
            LblDrID.Name = "LblDrID";
            LblDrID.Size = new Size(109, 21);
            LblDrID.TabIndex = 1;
            LblDrID.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10.2F);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(87, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "T.C. Kimlik Nu :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RchComplaint);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.Aqua;
            groupBox2.Location = new Point(15, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(361, 172);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detayları :";
            // 
            // RchComplaint
            // 
            RchComplaint.Location = new Point(6, 40);
            RchComplaint.Name = "RchComplaint";
            RchComplaint.Size = new Size(349, 120);
            RchComplaint.TabIndex = 0;
            RchComplaint.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.ForeColor = Color.Aqua;
            groupBox3.Location = new Point(383, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(473, 438);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Detayları :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(467, 409);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnExit);
            groupBox4.Controls.Add(BtnNotice);
            groupBox4.Controls.Add(BtnUpgrade);
            groupBox4.ForeColor = Color.Aqua;
            groupBox4.Location = new Point(15, 327);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(361, 125);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim :";
            // 
            // BtnExit
            // 
            BtnExit.ForeColor = SystemColors.ActiveCaptionText;
            BtnExit.Location = new Point(36, 73);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(284, 38);
            BtnExit.TabIndex = 3;
            BtnExit.Text = "Çıkış";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnNotice
            // 
            BtnNotice.ForeColor = SystemColors.ActiveCaptionText;
            BtnNotice.Location = new Point(191, 29);
            BtnNotice.Name = "BtnNotice";
            BtnNotice.Size = new Size(129, 38);
            BtnNotice.TabIndex = 1;
            BtnNotice.Text = "Duyurular";
            BtnNotice.UseVisualStyleBackColor = true;
            BtnNotice.Click += BtnNotice_Click;
            // 
            // BtnUpgrade
            // 
            BtnUpgrade.ForeColor = SystemColors.ActiveCaptionText;
            BtnUpgrade.Location = new Point(36, 29);
            BtnUpgrade.Name = "BtnUpgrade";
            BtnUpgrade.Size = new Size(129, 38);
            BtnUpgrade.TabIndex = 0;
            BtnUpgrade.Text = "Bilgi Düzenle";
            BtnUpgrade.UseVisualStyleBackColor = true;
            BtnUpgrade.Click += BtnUpgrade_Click;
            // 
            // FrmDoctorDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(868, 464);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.Aqua;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmDoctorDetails";
            Text = "Doctor Detay Paneli";
            Load += FrmDoctorDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblDrName;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridView1;
        private RichTextBox RchComplaint;
        private GroupBox groupBox4;
        private Button BtnExit;
        private Button BtnNotice;
        private Button BtnUpgrade;
        public Label LblDrID;
    }
}