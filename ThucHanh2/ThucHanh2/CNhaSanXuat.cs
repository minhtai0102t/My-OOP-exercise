using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh2
{
    class CNhaSanXuat
    {
        private string MaNSX;
        private string TenNSX;
        private string SDT;
        private string DiaChi;

        public string MaNSX1 { get => MaNSX; set => MaNSX = value; }
        public string TenNSX1 { get => TenNSX; set => TenNSX = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }

        public CNhaSanXuat()
        {
            this.MaNSX = "";
            this.TenNSX = "";
            this.SDT = "";
            this.DiaChi = "";

        }
        public CNhaSanXuat(string ma,string ten,string sdt,string diachi)
        {
            this.MaNSX = ma;
            this.TenNSX = ten;
            this.SDT = sdt;
            this.DiaChi = diachi;
        }

    }
}
