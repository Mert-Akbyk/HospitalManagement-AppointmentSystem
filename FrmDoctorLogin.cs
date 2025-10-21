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
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }

        SqlConnect conn10 = new SqlConnect();
        public static string DoctorID;

        private void BtnLoginP_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Doctor where DoctorIDNo=@p1 and DoctorPW=@p2", conn10.connect());
            command.Parameters.AddWithValue("@p1", MskIdentityDr.Text);
            command.Parameters.AddWithValue("@p2", TxtPwD.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                FrmDoctorDetails fr = new FrmDoctorDetails();
                fr.IDNo = MskIdentityDr.Text;
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
