using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace HospitalManagement_AppointmentSystem
{
    public partial class FrmPatientSignUp : Form
    {
        public FrmPatientSignUp()
        {
            InitializeComponent();
        }

        SqlConnect conn2 = new SqlConnect();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Patient (PatientName, PatientSurname, PatientIDNo, PatientTelNo, PatientGender, PatientPW) values (@p1, @p2, @p3, @p4, @p5, @p6)", conn2.connect());
            command.Parameters.AddWithValue("@p1", TxtNameP.Text);
            command.Parameters.AddWithValue("@p2", TxtSurnameP.Text);
            command.Parameters.AddWithValue("@p3", MskIDP.Text);
            command.Parameters.AddWithValue("@p4", MskTelP.Text);
            command.Parameters.AddWithValue("@p5", CmbGenderP.Text);
            command.Parameters.AddWithValue("@p6", TxtPwP.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Your registration has been successfully completed. Your password: " + TxtPwP.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
            conn2.connect().Close();
        }
    }
}
