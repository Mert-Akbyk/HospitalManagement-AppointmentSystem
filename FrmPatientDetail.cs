using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace HospitalManagement_AppointmentSystem
{
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }

        public string IDNo;
        SqlConnect conn4 = new SqlConnect();

        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            // Display patient information
            LblIdentity.Text = IDNo;
            SqlCommand command = new SqlCommand("select PatientName, PatientSurname from Tbl_Patient where PatientIDNo=@p1", conn4.connect());
            command.Parameters.AddWithValue("@p1", LblIdentity.Text);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    LblPatientInfo.Text = reader[0] + " " + reader[1];
                }
            }

            // Load patient's appointments
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Dates WHERE PatientIdentity = @id", conn4.connect());
            da.SelectCommand.Parameters.AddWithValue("@id", LblIdentity.Text);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Load branches into combo box
            SqlCommand command2 = new SqlCommand("select BranchesName from Tbl_Branches", conn4.connect());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                CmbBranch.Items.Add(reader2[0]);
            }
            conn4.connect().Close();
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load doctors based on selected branch
            CmbDoctorInfo.Items.Clear();
            SqlCommand command = new SqlCommand("select DoctorName, DoctorSurname from Tbl_Doctor where DoctorBranch=@p1", conn4.connect());
            command.Parameters.AddWithValue("@p1", CmbBranch.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CmbDoctorInfo.Items.Add(reader[0] + " " + reader[1]);
            }
            conn4.connect().Close();
        }

        private void CmbDoctorInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load available appointments based on selected branch and doctor
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Dates WHERE DateBranche = @branch AND DateDoctor = @doctor AND DateInfo = 0", conn4.connect());
            da.SelectCommand.Parameters.AddWithValue("@branch", CmbBranch.Text);
            da.SelectCommand.Parameters.AddWithValue("@doctor", CmbDoctorInfo.Text);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn4.connect().Close();

        }

        private void LnkChangeInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientInfoEditing frm = new FrmPatientInfoEditing();
            frm.IDNo = LblIdentity.Text;
            frm.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }

        private void BtnMakeApp_Click(object sender, EventArgs e)
        {
            UpdateAppointment();
            MessageBox.Show("Randevu Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshAppointments();
        }

        private void UpdateAppointment()
        {
            using (SqlCommand command = new SqlCommand("UPDATE Tbl_Dates SET DateInfo=1, PatientIdentity=@p1, PatientCompalint=@p2 WHERE DateID=@p3", conn4.connect()))
            {
                command.Parameters.AddWithValue("@p1", LblIdentity.Text);
                command.Parameters.AddWithValue("@p2", RchComplaint.Text);
                command.Parameters.AddWithValue("@p3", TxtID.Text);
                command.ExecuteNonQuery();
            }
            conn4.connect().Close();
        }

        private void RefreshAppointments()
        {
            using (SqlCommand refcmd = new SqlCommand("SELECT * FROM Tbl_Dates WHERE PatientIdentity=@p1", conn4.connect()))
            {
                refcmd.Parameters.AddWithValue("@p1", LblIdentity.Text);
                SqlDataAdapter da = new SqlDataAdapter(refcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            conn4.connect().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
