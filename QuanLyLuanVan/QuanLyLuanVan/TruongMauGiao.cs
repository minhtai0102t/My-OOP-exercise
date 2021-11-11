using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyLuanVan
{
    class TruongMauGiao
    {
        private string MaTruong;
        private string TenTruong;
        private string DiaChiTruong;
        private int SoLuongHS;


        public TruongMauGiao()
        {

            this.MaTruong = "";
            this.TenTruong = "";
            this.DiaChiTruong = "";
            this.SoLuongHS = 0;
        }
        public string XuLyMaTruong {
            get { return this.MaTruong; }
            set { this.MaTruong = value; }
        }
        public string XuLyTenTruong{
            get {return this.TenTruong;}
            set { this.TenTruong = value; }
        }
        public string XuLyDiaChi
        {
            get { return this.DiaChiTruong; }
            set { this.DiaChiTruong = value; }
        }
        public int XuLySoLuongHS
        {
            get { return this.SoLuongHS; }
            set { this.SoLuongHS = value; }
        }
        public void nhapTruong()
        {
            Console.Write("Nhập mã trường: ");
            string matruong = "";
            do
            {
                matruong = Console.ReadLine();
                if (matruong.Equals(""))
                {
                    Console.WriteLine("Mã trường không được để trống!");
                }    
               
            } while (matruong.Equals(""));
            this.XuLyMaTruong = matruong;
            Console.Write("Nhập tên trường: ");
            string tentruong = "";
            do
            {
                tentruong = Console.ReadLine();
                if (tentruong.Equals(""))
                {
                    Console.WriteLine("Tên trường không được để trống!");
                }
                    
            } while (tentruong.Equals(""));
            this.XuLyTenTruong = tentruong;
            Console.Write("Nhập địa chỉ trường: ");
            string diachi = "";
            do
            {
                diachi = Console.ReadLine();

                if (diachi.Equals(""))
                {
                    Console.WriteLine("Địa chỉ không được để trống!");
                }

            } while (diachi.Equals(""));
            this.XuLyDiaChi = diachi;
            Console.Write("Nhập số lượng học sinh: ");
            int soluong;
            do
            {
                try
                {
                    soluong = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Giá trị phải là 1 số nguyên");
                    soluong = -1;
                }
            } while (soluong == -1);
            this.XuLySoLuongHS = soluong;
        }
        public void xuatTruong()
        {
            Console.Write("Mã trường: ");
            Console.WriteLine(this.XuLyMaTruong);
            Console.Write("Tên trường: ");
            Console.WriteLine(this.XuLyTenTruong);
            Console.Write("Địa chỉ: ");
            Console.WriteLine(this.XuLyDiaChi);
            Console.Write("Số lượng học sinh: ");
            Console.WriteLine(this.XuLySoLuongHS);
        }


    }
}
