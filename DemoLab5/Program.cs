using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVienIT svIT = new SinhVienIT("Nguyen van A", "IT", 10, 8, 8);

            SinhVienBiz svBiz = new SinhVienBiz("Nguyen van B", "Biz", 10, 8);

            svIT.xuat();
            svBiz.xuat();

            Console.ReadLine();
        }
    }
}
