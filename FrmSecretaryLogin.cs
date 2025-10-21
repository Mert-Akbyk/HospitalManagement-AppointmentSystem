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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        SqlConnect conn6 = new SqlConnect();

        private void BtnLoginS_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Secretary where SecretaryIDNo=@p1 and SecretaryPW=@p2", conn6.connect());
            command.Parameters.AddWithValue("@p1", MskIdentityS.Text);
            command.Parameters.AddWithValue("@p2", TxtPwS.Text);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    FrmSecretaryDetails fr = new FrmSecretaryDetails();
                    fr.IDNo = MskIdentityS.Text;
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
