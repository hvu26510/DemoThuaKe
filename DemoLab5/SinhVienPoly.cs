using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLab5
{
    abstract internal class SinhVienPoly
    {
        protected string hoTen;
        protected string nganh;
        public abstract double getDiem();

        public string getHocLuc()
        {
            if (this.getDiem() < 5)
            {
                return "Y";
            }
            else if (this.getDiem() < 6.5)
            {
                return "TB";
            }
            else if (this.getDiem() < 7.5)
            {
                return "K";
            }
            else
            {
                return "Xuat sac";
            }

        }

        public void xuat()
        {
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.WriteLine("Nganh : " + this.nganh);
            Console.WriteLine("Diem  : " + this.getDiem());
            Console.WriteLine("Hoc Luc: " + this.getHocLuc());
        }

    }

    class SinhVienIT : SinhVienPoly
    {
        private double diemJava;
        private double diemCSS;
        private double diemHTML;
        public override double getDiem()
        {
            return (this.diemJava*2+ this.diemCSS +this.diemHTML)/4;
        }

        public SinhVienIT(string hoTen, string nganh,double diemJava, double diemCSS, double diemHTML)
        {
            this.hoTen = hoTen;
            this.nganh = nganh;
            this.diemJava = diemJava;
            this.diemCSS = diemCSS;
            this.diemHTML = diemHTML;
        }
    }

    class SinhVienBiz : SinhVienPoly
    {
        private double diemMarketing;
        private double diemSales;
        public override double getDiem()
        {
            return (this.diemMarketing * 2 + this.diemSales) / 3;
        }

        public SinhVienBiz(string hoTen, string nganh, double diemMarketing, double diemSales)
        {
            this.hoTen = hoTen;
            this.nganh = nganh;
            this.diemMarketing = diemMarketing;
            this.diemSales = diemSales;
        }
    }
}
