using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace HospitalManagement_AppointmentSystem
{
    public partial class FrmPatientInfoEditing : Form
    {
        public FrmPatientInfoEditing()
        {
            InitializeComponent();
        }

        public string IDNo;
        SqlConnect conn5 = new SqlConnect();

        private void FrmPatientInfoEditing_Load(object sender, EventArgs e)
        {
            MskIDP.Text = IDNo;
            SqlCommand command = new SqlCommand("select * from Tbl_Patient where PatientIDNo=@p1", conn5.connect());
            command.Parameters.AddWithValue("@p1", MskIDP.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TxtNameP.Text = reader[1].ToString();
                TxtSurnameP.Text = reader[2].ToString();
                MskTelP.Text = reader[4].ToString();
                TxtPwP.Text = reader[5].ToString();
                CmbGenderP.Text = reader[6].ToString();
            }
            conn5.connect().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn = conn5.connect();
            SqlCommand command2 = new SqlCommand("update Tbl_Patient set PatientName=@p1, PatientSurname=@p2, PatientTel=@p3, PatientPw=@p4, PatientGender=@p5 where PatientIDNo=@p6", conn);
            command2.Parameters.AddWithValue("@p1", TxtNameP.Text);
            command2.Parameters.AddWithValue("@p2", TxtSurnameP.Text);
            command2.Parameters.AddWithValue("@p3", MskTelP.Text);
            command2.Parameters.AddWithValue("@p4", TxtPwP.Text);
            command2.Parameters.AddWithValue("@p5", CmbGenderP.Text);
            command2.Parameters.AddWithValue("@p6", MskIDP.Text);
            command2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Your information has been successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
