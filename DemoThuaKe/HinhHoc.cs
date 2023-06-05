using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace DemoThuaKe
{
    abstract internal class Hinh
    {
        public abstract double TinhDienTich();
    }

    class Tron : Hinh
    {
        private double bk;

        public double getBK()
        {
            return this.bk;
        }

        public void setBk(double b)
        {
            this.bk = b;
        }
        public override double TinhDienTich()
        {
            return Math.PI * bk * bk;
        }
    }

    class Vuong : Hinh
    {
        private double canh;

        public double getCanh()
        {
            return this.canh;
        }
        public void setCanh(double c)
        {
            this.canh = c;
        }
        public override double TinhDienTich()
        {
            return canh * canh;
        }
    }
}
