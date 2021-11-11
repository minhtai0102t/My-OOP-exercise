using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyLuanVan
{
    class DanhSachTruong
    {
        private TruongMauGiao[] DSTruong;
        private int SoLuongTruong;


        public DanhSachTruong()
        {
            //Khởi tạo 1 DS trường khi gọi tới đối tượng DanhSachTruong
            DSTruong = new TruongMauGiao[50];
            this.SoLuongTruong = 0;
        }

        //Nhập ds trường
        public void nhapDSTruong(int n)
        {
            for (int i = 0; i < n; i++)
            {
                this.DSTruong[i] = new TruongMauGiao();
                Console.WriteLine("===========Trường mẫu giáo " + i + "=========== \n");
                this.DSTruong[i].nhapTruong();
            }
            this.SoLuongTruong = n;
        }
        //Xuất ds trường
        public void XuatDsTruong()
        {
            if (this.SoLuongTruong == 0)
            {
                Console.WriteLine("Danh sách rỗng ~.~");
            }
            else
            {

                for (int i = 0; i < this.SoLuongTruong; i++)
                {
                    Console.WriteLine("======Trường mẫu giáo thứ " + i + "========= \n");
                    this.DSTruong[i].xuatTruong();

                }
            }
        }
        //Chèn 1 trường vào danh sách
        public void ThemTruong(int pos, TruongMauGiao val)
        {
            if (pos > this.SoLuongTruong - 1)
            {
                Console.WriteLine("Vị trí chèn vượt quá số lượng phần tử của mảng, tự động thêm vào cuối mảng!");
                Console.WriteLine("Nhập thông tin trường cần chèn: ");
                val.nhapTruong();
                this.SoLuongTruong++;
                this.DSTruong[this.SoLuongTruong - 1] = val;
            }
            else
            {
                Console.WriteLine("Nhập thông tin trường cần chèn: ");
                val.nhapTruong();
                for (int i = this.SoLuongTruong - 1; i >= pos; i--)
                {
                    this.DSTruong[i + 1] = this.DSTruong[i];
                }
                this.DSTruong[pos] = val;

                this.SoLuongTruong++;
            }
        }
        public TruongMauGiao TimKiem(string s)
        {
            for (int i = 0; i < this.SoLuongTruong; i++)
            {
                if (this.DSTruong[i].XuLyMaTruong == s)
                {
                    return this.DSTruong[i];
                }
            }
            return null;
        }
        public int IndexOfDeleteElement(string s)
        {
            for (int i = 0; i < this.SoLuongTruong; i++)
            {
                if (this.DSTruong[i].XuLyMaTruong == s)
                {
                    return i;
                }
            }
            return -1;
        }
        public void XoaTruong(string s)
        {
            int index = IndexOfDeleteElement(s);
            if (index != -1)
            {
                for (int i = index; i < this.SoLuongTruong; i++)
                {
                    this.DSTruong[i] = this.DSTruong[i + 1];
                }
                this.SoLuongTruong--;
            }
        }
        public void SapXepTangDan()
        {
            for(int i = 0; i < this.SoLuongTruong; i++)
            {
                for (int j = i + 1; j < this.SoLuongTruong; j++)
                {
                    if(this.DSTruong[i].XuLySoLuongHS > this.DSTruong[j].XuLySoLuongHS)
                    {
                        TruongMauGiao temp = this.DSTruong[i];
                        this.DSTruong[i] = this.DSTruong[j];
                        this.DSTruong[j] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sách đã được sắp xếp tăng dần theo số lượng HS");
        
        }
        public void SapXepGiamDan()
        {
            for (int i = 0; i < this.SoLuongTruong; i++)
            {
                for (int j = i + 1; j < this.SoLuongTruong; j++)
                {
                    if (this.DSTruong[i].XuLySoLuongHS < this.DSTruong[j].XuLySoLuongHS)
                    {
                        TruongMauGiao temp = this.DSTruong[i];
                        this.DSTruong[i] = this.DSTruong[j];
                        this.DSTruong[j] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sách đã được sắp xếp giảm dần theo số lượng HS");

        }

    }
}
