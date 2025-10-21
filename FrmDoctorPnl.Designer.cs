namespace HospitalManagement_AppointmentSystem
{
    partial class FrmDoctorPnl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctorPnl));
            CmbBranch = new ComboBox();
            TxtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtSurname = new TextBox();
            MskIdentity = new MaskedTextBox();
            TxtPW = new TextBox();
            dataGridView1 = new DataGridView();
            BtnAdd = new Button();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            BtnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CmbBranch
            // 
            CmbBranch.FormattingEnabled = true;
            CmbBranch.Location = new Point(126, 91);
            CmbBranch.Name = "CmbBranch";
            CmbBranch.Size = new Size(125, 28);
            CmbBranch.TabIndex = 3;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(126, 25);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(125, 27);
            TxtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 10.2F);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(12, 127);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 12;
            label1.Text = "T.C. Kimlik Nu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 10.2F);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(62, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 15;
            label2.Text = "Branş :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(80, 27);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 16;
            label3.Text = "Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 10.2F);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(54, 60);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 17;
            label4.Text = "Soyadı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 10.2F);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(69, 164);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 21);
            label5.TabIndex = 18;
            label5.Text = "Şifre :";
            // 
            // TxtSurname
            // 
            TxtSurname.Location = new Point(126, 58);
            TxtSurname.Name = "TxtSurname";
            TxtSurname.Size = new Size(125, 27);
            TxtSurname.TabIndex = 2;
            // 
            // MskIdentity
            // 
            MskIdentity.Location = new Point(126, 125);
            MskIdentity.Mask = "00000000000";
            MskIdentity.Name = "MskIdentity";
            MskIdentity.Size = new Size(125, 27);
            MskIdentity.TabIndex = 4;
            MskIdentity.ValidatingType = typeof(int);
            // 
            // TxtPW
            // 
            TxtPW.Location = new Point(126, 158);
            TxtPW.Name = "TxtPW";
            TxtPW.Size = new Size(125, 27);
            TxtPW.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(278, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(574, 188);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.ButtonHighlight;
            BtnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnAdd.ForeColor = Color.Black;
            BtnAdd.Location = new Point(278, 206);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(117, 35);
            BtnAdd.TabIndex = 36;
            BtnAdd.Text = "Ekle";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = SystemColors.ButtonHighlight;
            BtnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(587, 206);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(117, 35);
            BtnDelete.TabIndex = 37;
            BtnDelete.Text = "Sil";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = SystemColors.ButtonHighlight;
            BtnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnUpdate.ForeColor = Color.Black;
            BtnUpdate.Location = new Point(435, 206);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(117, 35);
            BtnUpdate.TabIndex = 38;
            BtnUpdate.Text = "Güncelle";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.BackColor = SystemColors.ButtonHighlight;
            BtnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnRefresh.ForeColor = Color.Black;
            BtnRefresh.Location = new Point(735, 206);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(117, 35);
            BtnRefresh.TabIndex = 39;
            BtnRefresh.Text = "Yenile";
            BtnRefresh.UseVisualStyleBackColor = false;
            BtnRefresh.Click += button1_Click;
            // 
            // FrmDoctorPnl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(864, 256);
            Controls.Add(BtnRefresh);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(TxtPW);
            Controls.Add(MskIdentity);
            Controls.Add(TxtSurname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CmbBranch);
            Controls.Add(TxtName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmDoctorPnl";
            Text = "FrmDoctorPnl";
            Load += FrmDoctorPnl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbBranch;
        private TextBox TxtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtSurname;
        private MaskedTextBox MskIdentity;
        private TextBox TxtPW;
        private DataGridView dataGridView1;
        internal Button BtnAdd;
        internal Button BtnDelete;
        internal Button BtnUpdate;
        internal Button BtnRefresh;
    }
}