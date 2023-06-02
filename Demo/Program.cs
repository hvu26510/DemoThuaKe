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
          
            //listSV.Remove(getValue(ref listSV));

            Xuat(listSV);


            Console.ReadLine();
        }

        static void addDataDemo(ref ArrayList list)
        {
            SinhVien sv1 = new SinhVien("abc", 10, "abc@email");
            SinhVien sv2 = new SinhVien("def", 10, "def@email");
            SinhVien sv3 = new SinhVien("GH", 10, "gh@email");
            SinhVien sv4 = new SinhVien("YK", 10, "yk@email");

            list.Add(sv1);
            list.Add(sv2);
            list.Add(sv3);
            list.Add(sv4);

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
