using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace HospitalManagement_AppointmentSystem
{
    internal class SqlConnect    
    {
       public SqlConnection connect() 
        {
            SqlConnection conn = new SqlConnection("Data Source=EFE-AKBIYIK\\SQLEXPRESS;Initial Catalog=HospitalReservationSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            conn.Open();
            return conn;
        }
    }
}
