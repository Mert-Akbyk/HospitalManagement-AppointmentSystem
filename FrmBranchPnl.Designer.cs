namespace HospitalManagement_AppointmentSystem
{
    partial class FrmBranchPnl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBranchPnl));
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnAdd = new Button();
            dataGridView1 = new DataGridView();
            TxtBrName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TxtBrID = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = SystemColors.ButtonHighlight;
            BtnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnUpdate.ForeColor = Color.Black;
            BtnUpdate.Location = new Point(217, 92);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(90, 35);
            BtnUpdate.TabIndex = 52;
            BtnUpdate.Text = "Güncelle";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = SystemColors.ButtonHighlight;
            BtnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.Location = new Point(217, 133);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(90, 35);
            BtnDelete.TabIndex = 51;
            BtnDelete.Text = "Yenile";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = SystemColors.ButtonHighlight;
            BtnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnAdd.ForeColor = Color.Black;
            BtnAdd.Location = new Point(121, 92);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(90, 35);
            BtnAdd.TabIndex = 50;
            BtnAdd.Text = "Ekle";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(421, 142);
            dataGridView1.TabIndex = 49;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // TxtBrName
            // 
            TxtBrName.Location = new Point(121, 59);
            TxtBrName.Name = "TxtBrName";
            TxtBrName.Size = new Size(186, 27);
            TxtBrName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 10.2F);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(31, 59);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 44;
            label4.Text = "Branş Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 10.2F);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(40, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 43;
            label3.Text = "Branş ID :";
            // 
            // TxtBrID
            // 
            TxtBrID.Location = new Point(121, 26);
            TxtBrID.Name = "TxtBrID";
            TxtBrID.Size = new Size(186, 27);
            TxtBrID.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(121, 133);
            button1.Name = "button1";
            button1.Size = new Size(90, 35);
            button1.TabIndex = 53;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmBranchPnl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(742, 180);
            Controls.Add(button1);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(TxtBrName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TxtBrID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmBranchPnl";
            Text = "FrmBranchPnl";
//            Load += FrmBranchPnl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button BtnUpdate;
        internal Button BtnDelete;
        internal Button BtnAdd;
        private DataGridView dataGridView1;
        private TextBox TxtBrName;
        private Label label4;
        private Label label3;
        private TextBox TxtBrID;
        internal Button button1;
    }
}