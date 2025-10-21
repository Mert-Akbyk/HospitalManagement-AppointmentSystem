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
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        SqlConnect conn3 = new SqlConnect();

        private void lnkSignP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignUp fr = new FrmPatientSignUp();
            fr.Show();
        }

        private void BtnLoginP_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Patient where PatientIDNo=@p1 and PatientPW=@p2", conn3.connect());
            command.Parameters.AddWithValue("@p1", MskIDP.Text);
            command.Parameters.AddWithValue("@p2", TxtPwP.Text);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    FrmPatientDetail fr = new FrmPatientDetail();
                    fr.IDNo = MskIDP.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid ID number or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
