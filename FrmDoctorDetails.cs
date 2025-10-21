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
    public partial class FrmDoctorDetails : Form
    {
        public FrmDoctorDetails()
        {
            InitializeComponent();
        }

        SqlConnect conn11 = new SqlConnect();
        public string IDNo;


        private void FrmDoctorDetails_Load(object sender, EventArgs e)
        {
            // Display doctor information
            LblDrID.Text = IDNo;
            SqlCommand command = new SqlCommand("select DoctorName + ' ' + DoctorSurname from Tbl_Doctor where DoctorIDNo=@p1", conn11.connect());
            command.Parameters.AddWithValue("@p1", LblDrID.Text);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    LblDrName.Text = reader[0].ToString();
                }
            }

            // Display doctor's appointments
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Dates where DateDoctor='" + LblDrName.Text + "'", conn11.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn11.connect().Close();
        }

        private void BtnNotice_Click(object sender, EventArgs e)
        {
            FrmNotice fr = new FrmNotice();
            fr.Show();
        }

        private void BtnUpgrade_Click(object sender, EventArgs e)
        {
            FrmDoctorInfoEditing fr = new FrmDoctorInfoEditing();
            fr.IDNo = LblDrID.Text;
            fr.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Display selected appointment complaint
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            RchComplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
