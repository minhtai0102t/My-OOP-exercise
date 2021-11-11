using System;
using System.Text;

namespace QuanLyLuanVan
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DanhSachTruong DSTruongMauGiao = new DanhSachTruong();

            while (true)
            {
                int n;
                TruongMauGiao t1 = new TruongMauGiao();
                string s;
                Console.WriteLine("==============MENU================");
                Console.WriteLine("1. Nhập danh sách các trường mẫu giáo");
                Console.WriteLine("2. Chèn một trường vào vị trí bất kỳ trong danh sách");
                Console.WriteLine("3. Tìm kiếm trường theo mã trường");
                Console.WriteLine("4. Xóa trường theo mã trường");
                Console.WriteLine("5. Sắp xếp theo số lượng học sinh tăng dần");
                Console.WriteLine("6. Sắp xếp theo số lượng học sinh giảm dần");
                Console.WriteLine("7. Xuất danh sách các trường");
                Console.Write("Mời bạn nhập lựa chọn(nhập 99 để thoát): ");
                int luachon;
                try
                {
                    luachon = int.Parse(Console.ReadLine());
                }
                catch
                {
                    luachon = -99;
                }
                if (luachon == 99)
                {
                    Console.WriteLine("Kết thúc chương trình!!!");
                    break;
                }
                switch (luachon)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Nhập số lượng trường: ");
                            try
                            {
                                n = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                Console.WriteLine("Giá trị phải là một số nguyên");
                                n = -1;
                            }
                        } while (n == -1);
                        DSTruongMauGiao.nhapDSTruong(n);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Nhập vị trí muốn thêm: ");
                            try
                            {
                                n = int.Parse(Console.ReadLine());
                            }
                            catch
                            {

                                Console.WriteLine("Giá trị phải là một số nguyên");
                                n = -1;
                            }
                        } while (n == -1);
                        DSTruongMauGiao.ThemTruong(n,t1);
                        break;
                    case 3:

                        Console.WriteLine("Nhập mã trường cần tìm: ");
                        s = Console.ReadLine();

                        t1 = DSTruongMauGiao.TimKiem(s);
                        if (t1==null)
                        {
                            Console.WriteLine("Không tìm thấy trường có mã phù hợp");
                        }
                        else
                        {
                            t1.xuatTruong();
                        }
                        break;

                    case 4:
                        Console.WriteLine("Nhập mã trường cần xóa: ");
                        s = Console.ReadLine();

                        t1 = DSTruongMauGiao.TimKiem(s);
                        if (t1 == null)
                        {
                            Console.WriteLine("Không tìm thấy trường có mã phù hợp");
                        }
                        else
                        {
                            DSTruongMauGiao.XoaTruong(s);
                            Console.WriteLine("Đã xóa!");

                        }
                        break;
                    case 5:
                        DSTruongMauGiao.SapXepTangDan();
                        break;
                    case 6:
                        DSTruongMauGiao.SapXepGiamDan();
                        break;
                    case 7:
                        DSTruongMauGiao.XuatDsTruong();
                        break;
                    default:
                        Console.WriteLine("Nhap sai lua chon vui long nhap lai");
                        break;
                }
                Console.WriteLine("Nhấn phím bất kỳ để tiếp tục");
                Console.ReadKey();
                Console.Clear();

            }



        }
    }
}
