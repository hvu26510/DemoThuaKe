using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class SinhVien 
    {
        private int maSV;
        private string name;
        private double diem;
        private string email;

        public string getName()
        {
            return this.name;
        }
        public int getMaSV()
        {
            return this.maSV;
        }

        public double getDiem()
        {
            return diem;
        }
        public string HocLuc()
        {
            if(this.diem < 5)
            {
                return "Y";
            }else if(this.diem <6.5)
            {
                return "TB";
            }else if(this.diem < 7.5)
            {
                return "K";
            }
            else
            {
                return "Xuat sac";
            }

        }

        public void setName(string name)
        {
            while (name == "")
            {
                Console.WriteLine("Ten rong, yeu cau nhap lai");
                name = Console.ReadLine();
            }
            this.name = name;   
        }

        public void Nhap()
        {
            Console.Write("Ten SV : ");
            this.setName(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Diem: ");
            this.diem = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Email: ");
            this.email = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"Ten : {this.name}");
            Console.WriteLine($"Diem : {this.diem}");
            Console.WriteLine($"email : {this.email}");
            Console.WriteLine($"Hoc Luc : {this.HocLuc()}");
        }

        public SinhVien(int maSV, string name, double diem, string email)
        {
            this.maSV = maSV;
            this.name = name;
            this.diem = diem;
            this.email = email;
        }

        public SinhVien()
        {
        }
    }

    public class SinhVienComparer : IComparer<SinhVien>
    {
        public int Compare(SinhVien x, SinhVien y)
        {
            // Sắp xếp theo điểm giảm dần
            return y.getDiem().CompareTo(x.getDiem());
        }
    }

}
