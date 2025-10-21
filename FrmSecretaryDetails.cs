using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HospitalManagement_AppointmentSystem
{
    public partial class FrmSecretaryDetails : Form
    {
        public FrmSecretaryDetails()
        {
            InitializeComponent();
        }

        public string IDNo;
        SqlConnect conn7 = new SqlConnect();

        private void FrmSecretaryDetails_Load(object sender, EventArgs e)
        {
            // Display secretary information
            LblSecretaryID.Text = IDNo;
            SqlCommand command = new SqlCommand("select SecretaryNameSurname from Tbl_Secretary where SecretaryIDNo=@p1", conn7.connect());
            command.Parameters.AddWithValue("@p1", LblSecretaryID.Text);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    LblSecretaryName.Text = reader[0].ToString();
                }
            }
            conn7.connect().Close();

            // Display branches
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Tbl_Branches", conn7.connect());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            conn7.connect().Close();

            // Display doctors
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoctorName + ' ' + DoctorSurname) as 'Doctor Name', DoctorBranch as 'Branch' from Tbl_Doctor", conn7.connect());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            conn7.connect().Close();

            // Display branches in combobox
            SqlCommand command2 = new SqlCommand("select BranchesName from Tbl_Branches", conn7.connect());
            using (SqlDataReader reader2 = command2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    CmbBranch.Items.Add(reader2[0]);
                }
            }
            conn7.connect().Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("insert into Tbl_Dates (DateTime, DateTimeOclock, DateBranche, DateDoctor) values (@p1, @p2, @p3, @p4)", conn7.connect()))
            {
                command.Parameters.AddWithValue("@p1", MskDate.Text);
                command.Parameters.AddWithValue("@p2", MskOclock.Text);
                command.Parameters.AddWithValue("@p3", CmbBranch.Text);
                command.Parameters.AddWithValue("@p4", CmbDr.Text);
                command.ExecuteNonQuery();
                if (ChkInfo.Checked)
                {
                    using (SqlCommand command2 = new SqlCommand("insert into Tbl_Dates (DateInfo) values (@p1)", conn7.connect()))
                    {
                        command2.Parameters.AddWithValue("@p1", 1);
                        command2.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Randevu Kaydedildi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("UPDATE Tbl_Dates SET DateInfo = 1 WHERE DateID = @p1", conn7.connect()))
            {
                command.Parameters.AddWithValue("@p1", TxtID.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Randevu Güncellendi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDr.Items.Clear();
            SqlCommand command = new SqlCommand("select DoctorName, DoctorSurname from Tbl_Doctor where DoctorBranch=@p1", conn7.connect());
            command.Parameters.AddWithValue("@p1", CmbBranch.Text);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CmbDr.Items.Add(reader[0] + " " + reader[1]);
                }
            }
            conn7.connect().Close();
        }

        private void BtnNotice_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Notice (Notice) values (@p1)", conn7.connect());
            command.Parameters.AddWithValue("@p1", RchNotice.Text);
            command.ExecuteNonQuery();
            conn7.connect().Close();
            MessageBox.Show("Duyuru Yayınlandı.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDrPnl_Click(object sender, EventArgs e)
        {
            FrmDoctorPnl drpnl = new FrmDoctorPnl();
            drpnl.Show();
        }

        private void BtnBrPnl_Click(object sender, EventArgs e)
        {
            FrmBranchPnl brpnl = new FrmBranchPnl();
            brpnl.Show();
        }

        private void BtnDateList_Click(object sender, EventArgs e)
        {
            FrmDateList dl = new FrmDateList();
            dl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNotice fr = new FrmNotice();
            fr.Show();

        }
    }
}

