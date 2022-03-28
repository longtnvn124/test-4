using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKSpj.DAO;

namespace QLKSpj
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }

        public void loadlishPhong()
        {
            List<Phong> phonglist =  PhongDAO.LoadPhong();
            foreach(Phong item in phonglist)
            {
                Button btn = new Button() { Width = PhongDAO.btWhidth, Height = PhongDAO.btHeight };
                btn.Text = item.Ten + Environment.NewLine +"Loại: "+ item.Loai + Environment.NewLine +"Tình Trạng: "+ item.TinhTrang;
                btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                flowLayoutPanelPhong.Controls.Add(btn);
            }
        }

        public void loadlistKH()
        {
            string query = "SELECT * FROM KhachHang";
            listViewKhachHang.Columns.Add(dataprovider.ExQuery(query));
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            loadlishPhong();
        }
    }
    
}
