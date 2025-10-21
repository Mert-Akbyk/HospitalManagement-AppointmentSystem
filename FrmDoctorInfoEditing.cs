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
    public partial class FrmDoctorInfoEditing : Form
    {
        public FrmDoctorInfoEditing()
        {
            InitializeComponent();
        }

        public string IDNo;
        SqlConnect connectString = new SqlConnect();

        private void FrmDoctorInfoEditing_Load(object sender, EventArgs e)
        {
            MskIDDr.Text = IDNo;
            SqlCommand command = new SqlCommand("select * from Tbl_Doctor where DoctorIDNo=@p1", connectString.connect());
            command.Parameters.AddWithValue("@p1", MskIDDr.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TxtNameDr.Text = reader[1].ToString();
                TxtSurnameDr.Text = reader[2].ToString();
                TxtPwDr.Text = reader[4].ToString();
                CmbBrancDr.Text = reader[3].ToString();
            }
            connectString.connect().Close();
        }

        private void BrnUpD_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection();
            connect = connectString.connect();
            SqlCommand command = new SqlCommand("update Tbl_Doctor set DoctorName=@p1, DoctorSurname=@p2, DoctorPw=@p3, DoctorBranch=@p4 where DoctorIDNo=@p5", connect);
            command.Parameters.AddWithValue("@p1", TxtNameDr.Text);
            command.Parameters.AddWithValue("@p2", TxtSurnameDr.Text);
            command.Parameters.AddWithValue("@p3", TxtPwDr.Text);
            command.Parameters.AddWithValue("@p4", CmbBrancDr.Text);
            command.Parameters.AddWithValue("@p5", MskIDDr.Text);
            command.ExecuteNonQuery();
            connect.Close();

            // ✅ Show a message box asking if the user wants to perform another operation.
            DialogResult result = MessageBox.Show("Bilgileriniz güncellendi. Başka bir işlem yapmak istiyor musunuz? İstemiyorsanız Hayır'a basın.", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                Application.Exit(); // ❌ If it says no, exit the app.
            }
            else
            {
                MessageBox.Show("İşleme devam edebilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
