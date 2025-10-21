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
    public partial class FrmNotice : Form
    {
        public FrmNotice()
        {
            InitializeComponent();
        }

        SqlConnect conn8 = new SqlConnect();

        private void FrmNotice_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Tbl_Notice", conn8.connect());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn8.connect().Close();
        }
    }
}
