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
    public partial class FrmDoctorPnl : Form
    {
        public FrmDoctorPnl()
        {
            InitializeComponent();
        }

        SqlConnect sqlConnect = new SqlConnect();

        private void FrmDoctorPnl_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Doctor", sqlConnect.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnect.connect().Close();

            // Populate branches in combobox
            SqlCommand command = new SqlCommand("select BranchesName from Tbl_Branches", sqlConnect.connect());
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    CmbBranch.Items.Add(reader[0]);
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand add = new SqlCommand("insert into Tbl_Doctor (DoctorName, DoctorSurname, DoctorBranch, DoctorIDNo, DoctorPw) values (@p1, @p2, @p3, @p4, @p5)", sqlConnect.connect());
            add.Parameters.AddWithValue("@p1", TxtName.Text);
            add.Parameters.AddWithValue("@p2", TxtSurname.Text);
            add.Parameters.AddWithValue("@p3", CmbBranch.Text);
            add.Parameters.AddWithValue("@p4", MskIdentity.Text);
            add.Parameters.AddWithValue("@p5", TxtPW.Text);
            add.ExecuteNonQuery();
            sqlConnect.connect().Close();
            MessageBox.Show("Doctor added successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand del = new SqlCommand("delete from Tbl_Doctor where DoctorIDNo=@p1", sqlConnect.connect());
            del.Parameters.AddWithValue("@p1", MskIdentity.Text);
            del.ExecuteNonQuery();
            sqlConnect.connect().Close();
            MessageBox.Show("Doctor deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand upl = new SqlCommand("update Tbl_Doctor set DoctorName=@p1, DoctorSurname=@p2, DoctorBranch=@p3, DoctorPw=@p4 where DoctorIDNo=@p5", sqlConnect.connect());
            upl.Parameters.AddWithValue("@p1", TxtName.Text);
            upl.Parameters.AddWithValue("@p2", TxtSurname.Text);
            upl.Parameters.AddWithValue("@p3", CmbBranch.Text);
            upl.Parameters.AddWithValue("@p4", TxtPW.Text);
            upl.Parameters.AddWithValue("@p5", MskIdentity.Text);
            upl.ExecuteNonQuery();
            sqlConnect.connect().Close();
            MessageBox.Show("Doctor information updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand refCmd = new SqlCommand("select * from Tbl_Doctor", sqlConnect.connect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(refCmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnect.connect().Close();
            MessageBox.Show("Doctor list refreshed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            CmbBranch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            MskIdentity.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtPW.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }
    }
}
