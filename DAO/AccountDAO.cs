using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class AccountDAO
    {
        public static bool Login(string tk, string mk)
        {
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = '" + tk + "' AND MatKhau = '" + mk + "' ";
            DataTable kq = dataprovider.ExQuery(query);
            return kq.Rows.Count > 0;
        }
    }
}
