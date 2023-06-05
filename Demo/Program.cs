using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Timers;

namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ArrayList listSV = new ArrayList();
            addDataDemo(ref listSV);

            var sv = listSV.Cast<SinhVien>().Where(s => s.getMaSV() == 1).FirstOrDefault() ;

            sv.Xuat();

            //SinhVien sv = FindByMaSV(listSV, 1);
            //sv.Xuat();

            Console.ReadLine();
        }

        static SinhVien FindByMaSV(ArrayList list, int MaSV)
        {
            foreach(SinhVien sv in list)
            {
                if(sv.getMaSV() == MaSV)
                {
                    return sv;
                }
            }
            return null;

        }

        static void addDataDemo(ref ArrayList list)
        {
            SinhVien sv1 = new SinhVien(1,"abc", 10, "abc@email");
            SinhVien sv2 = new SinhVien(2,"def", 5, "def@email");
            SinhVien sv3 = new SinhVien(3,"GH", 7, "gh@email");
            SinhVien sv4 = new SinhVien(4,"YK", 9, "yk@email");
            SinhVien sv5 = new SinhVien(4, "YK", 9, "yk@email");
            list.Add(sv1);
            list.Add(sv2);
            list.Add(sv3);
            list.Add(sv4);
            list.Add(sv5);

        }

        static SinhVien getValue(ref ArrayList list)
        {
            foreach (SinhVien item in list)
            {
                if(item.getName() == "abc")
                {
                    return item;
                }
            }
            return null;
        }
        static void Nhap(ref ArrayList listSV)
        {

            do
            {
                Console.WriteLine("Nhap sinh vien:");
                SinhVien sv = new SinhVien();
                sv.Nhap();
                listSV.Add(sv);
                Console.WriteLine("Tiep tuc? nhan 'q' De thoat");

                if (Console.ReadLine() == "q")
                {
                    break;
                }
            } while (true);

        }
        static void Xuat(ArrayList listSV)
        {
            foreach (SinhVien i in listSV)
            {
                i.Xuat();
            }
        }
    }
}
