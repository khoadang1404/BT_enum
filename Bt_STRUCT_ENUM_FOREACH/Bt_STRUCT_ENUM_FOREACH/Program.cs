using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt_STRUCT_ENUM_FOREACH
{
    internal class Program
    {
        enum dienSinhVien
        {
            ngheo,
            trungBinh,
            khaGia,
        }
        struct SinhVien
        {
            public int MaSV_171;
            public string HoTen_171;
            public double dToan_171;
            public double dLy_171;
            public double dHoa_171;
            public int dienSV_171;
        }

        static void Nhap(out SinhVien SV)
        {
            Console.Write("Ma SV: ");
            SV.MaSV_171 = int.Parse(Console.ReadLine());
            Console.Write("Ho ten: ");
            SV.HoTen_171 = Console.ReadLine();
            Console.Write("Diem toan: ");
            SV.dToan_171 = Double.Parse(Console.ReadLine());
            Console.Write("Diem ly: ");
            SV.dLy_171 = Double.Parse(Console.ReadLine());
            Console.Write("Diem hoa: ");
            SV.dHoa_171 = Double.Parse(Console.ReadLine());
            Console.Write("Sinh vien thuoc dien: ");
            SV.dienSV_171 = int.Parse(Console.ReadLine());
        }

        static void Xuat(SinhVien SV)
        {
            Console.WriteLine("Ma so: " + SV.MaSV_171);
            Console.WriteLine("Ho ten: " + SV.HoTen_171);
            Console.WriteLine("Diem toan: " + SV.dToan_171);
            Console.WriteLine("Diem ly: " + SV.dLy_171);
            Console.WriteLine("Diem van: " + SV.dHoa_171);
            if (SV.dienSV_171 == (int)dienSinhVien.ngheo)
            {
                Console.WriteLine("Thuoc dien: Ho Ngheo");
            }
            else if (SV.dienSV_171 == (int)dienSinhVien.trungBinh)
            {
                Console.WriteLine("Thuoc dien: Trung binh");
            }
            else
            {
                Console.WriteLine("Thuoc dien: Kha gia");
            }
        }

        static double tinhDiemTBSV(SinhVien SV)
        {
            return (SV.dToan_171 + SV.dLy_171 + SV.dHoa_171) / 3;
        }

        static void Main(string[] args)
        {


            int n_171;
            do
            {
                Console.Write("Nhap so sinh vien: ");
                n_171 = int.Parse(Console.ReadLine());
            } while (n_171 <= 0);
            SinhVien[] sv_171 = new SinhVien[n_171];
            for (int i = 0; i < n_171; i++)
            {
                Console.Write("Nhap vao sinh thu {0}: \n", i + 1);
                Nhap(out sv_171[i]);
            }

            Console.WriteLine("DANH SACH SINH VIEN: ");
            int d_171 = 0;
            foreach (SinhVien sv in sv_171)
            {
                Console.WriteLine("Sinh vien thu {0}: \n", d_171 + 1);
                Xuat(sv);
                d_171++;
            }
            string timSV_171;
            Console.WriteLine("Nhap vao ten sv can tim kiem: ");
            timSV_171 = Console.ReadLine();
            foreach (SinhVien sv in sv_171)
            {
                if (sv.HoTen_171 == timSV_171)
                {
                    Console.WriteLine("Diem TB cua sinh vien {0} la: {1} ", timSV_171, tinhDiemTBSV(sv));
                }
                else
                {
                    Console.WriteLine("Khong tim thay sinh vien ten {0}", timSV_171);
                }
            }
            Console.ReadKey();
        }
    }
}
