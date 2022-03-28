using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSpj.DAO
{
    public class PhongDAO
    {
        public static int btWhidth = 120;
        public static int btHeight = 120;
        public static List<Phong> LoadPhong()
        {
            string query = "SELECT MaPhong, TenPhong, LoaiPhong, TinhTrang FROM Phong";
            List<Phong> Plist = new List<Phong>();

            DataTable data = dataprovider.ExQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                Plist.Add(phong);
            }


            return Plist;
        }
    }
}
