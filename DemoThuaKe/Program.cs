using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DemoThuaKe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv1 = new NhanVien("Nguyen van A", "So 7 Thien quang", "anv@email.vn", "1900100 Cos", "Chuyen gia - phu ho");
            NhanVien nv2 = new NhanVien("Nguyen van X", "Ha Noi", "xnv@email.vn", "0123456789", "KeToan");

            //nv1.Show();

            //KeToan kt = new KeToan("Nguyen van A", "So 7 Thien quang", "anv@email.vn", "1900100 Cos", "KeToan", 500);
            //kt.Show();

            ArrayList listNV = new ArrayList();

            listNV.Add(nv1);
            listNV.Add(nv2);

            foreach (NhanVien nv in listNV)
            {
                nv.Show();
            }

            Console.ReadLine();

        }
    }
}
