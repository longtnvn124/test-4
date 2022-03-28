using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKSpj.DAO
{
    public class Phong
    {
        private int id;
        private string ten;
        private string tinhTrang;
        private string loai;

        public Phong(int id, string ten, string tinhTrang, string loai)
        {
            this.id = id;
            this.ten = ten;
            this.tinhTrang = tinhTrang;
            this.loai = loai;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string Loai { get => loai; set => loai = value; }

        public Phong(DataRow row)
        {
            this.id = (int)row["MaPhong"];
            this.ten = row["TenPhong"].ToString();
            this.loai = row["LoaiPhong"].ToString();
            this.tinhTrang = row["TinhTrang"].ToString();
        }
    }
    
}
