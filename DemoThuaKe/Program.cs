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
            Tron t1 = new Tron();
            t1.setBk(3);

            Vuong v1 = new Vuong();
            v1.setCanh(5);

            Console.WriteLine("Dien tich t1 = " + t1.TinhDienTich());
            Console.WriteLine("Dien tich v1 = " + v1.TinhDienTich());


            Console.ReadLine();

        }
    }
}
