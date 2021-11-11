using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, CNhaSanXuat> dsNSX;
        private void hienDSNhaSanXuat()
        {
            dgv.DataSource = dsNSX.Values.ToList();
        }
        private CNhaSanXuat timNSX(string maNSX)
        {
            try
            {
                return dsNSX[maNSX];
            }
            catch
            {
                return null;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsNSX = new Dictionary<string, CNhaSanXuat>();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            CNhaSanXuat x = new CNhaSanXuat();
            x.MaNSX1 = mansx_txt.Text;
            x.TenNSX1 = tennsx_txt.Text;
            x.SDT1 = sdt_txt.Text;
            x.DiaChi1 = diachi_txt.Text;
            if (timNSX(x.MaNSX1) == null)
            {
                mansx_txt.Text = "";
                tennsx_txt.Text = "";
                sdt_txt.Text = "";
                diachi_txt.Text = "";
                dsNSX.Add(x.MaNSX1,x);
                hienDSNhaSanXuat();
            }
            else
            {
                MessageBox.Show("Mã nhà sản xuất" + x.MaNSX1 + " đã tồn tại. Không thể thêm!");
            }
        }


        private void remove_btn_Click(object sender, EventArgs e)
        {
            
            dsNSX.Remove(mansx_txt.Text);
            mansx_txt.Text = "";
            tennsx_txt.Text = "";
            sdt_txt.Text = "";
            diachi_txt.Text = "";
            hienDSNhaSanXuat();

        }

        private void update_btn_Click(object sender, EventArgs e)
        {

                CNhaSanXuat x = new CNhaSanXuat();
                x.MaNSX1 = mansx_txt.Text;  
                x.TenNSX1 = tennsx_txt.Text;
                x.SDT1 = sdt_txt.Text;
                x.DiaChi1 = diachi_txt.Text;

                mansx_txt.Text = "";
                tennsx_txt.Text = "";
                sdt_txt.Text = "";
                diachi_txt.Text = "";

                dsNSX[mansx_txt.Text] = x;
                hienDSNhaSanXuat();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dl =  MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo",MessageBoxButtons.YesNo);
            if (dl == DialogResult.Yes)
            {

                Close();
            }
        }
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.SelectedRows)
            {
                string mssv = r.Cells[0].Value.ToString();
                mansx_txt.Text = dsNSX[mssv].MaNSX1;
                tennsx_txt.Text = dsNSX[mssv].TenNSX1;
                sdt_txt.Text = dsNSX[mssv].SDT1;
                diachi_txt.Text = dsNSX[mssv].DiaChi1;
            }


        }
    }
}
