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
    public partial class FrmDateList : Form
    {
        public FrmDateList()
        {
            InitializeComponent();
        }
        SqlConnect conn = new SqlConnect();

        private void FrmDateList_Load(object sender, EventArgs e)
        {
            // Display all dates
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Dates", conn.connect());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.connect().Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            FrmSecretaryDetails dl = new FrmSecretaryDetails();
            dl.TxtID.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            dl.MskDate.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            dl.MskOclock.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            dl.CmbBranch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            dl.CmbDr.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            dl.Show();
        }
    }
}
