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
    public partial class FrmBranchPnl : Form
    {
        public FrmBranchPnl()
        {
            InitializeComponent();
        }

        SqlConnect conn = new SqlConnect();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand add = new SqlCommand("insert into Tbl_Branches (BranchesName) values (@p1)", conn.connect());
            add.Parameters.AddWithValue("@p1", TxtBrName.Text);
            add.ExecuteNonQuery();
            conn.connect().Close();
            MessageBox.Show("Branch added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand up = new SqlCommand("update Tbl_Branches set BranchesName=@p1 where BranchesID=@p2", conn.connect());
            up.Parameters.AddWithValue("@p1", TxtBrName.Text);
            up.Parameters.AddWithValue("@p2", TxtBrID.Text);
            up.ExecuteNonQuery();
            conn.connect().Close();
            MessageBox.Show("Branch updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand del = new SqlCommand("delete from Tbl_Branches where BranchesID=@p1", conn.connect());
            del.Parameters.AddWithValue("@p1", TxtBrID.Text);
            del.ExecuteNonQuery();
            conn.connect().Close();
            MessageBox.Show("Branch deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand refcmd = new SqlCommand("select * from Tbl_Branches", conn.connect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(refcmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.connect().Close();
            MessageBox.Show("Branch list refreshed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtBrID.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            TxtBrName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }
    }
}
