using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuaKe
{
    class HinhChuNhat
    {
        private double dai;
        private double rong;

        protected double Dai { get => dai; set => dai = value; }
        protected double Rong { get => rong; set => rong = value; }

        public HinhChuNhat()
        {

        }
        public HinhChuNhat(double dai, double rong)
        {
            this.Dai = dai;
            this.Rong = rong;
        }
        public double DienTich()
        {
            return this.dai * this.rong;
        }
        public double ChuVi()
        {
            return (this.dai + this.rong) * 2; 
        }
    }
}
