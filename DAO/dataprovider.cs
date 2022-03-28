using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class dataprovider
    {
        public static string sqlstring = "Data Source=ADMIN\\SQLQQ;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
    
        public static DataTable ExQuery(string query)
        {
            SqlConnection ketNoi = new SqlConnection(sqlstring);
            //query = "SELECT * FROM KhachHang ";

            ketNoi.Open();
            SqlCommand command = new SqlCommand(query, ketNoi);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table); 
            ketNoi.Close();
            return table;
        }
    }
}
