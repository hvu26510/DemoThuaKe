using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoThuaKe
{
    internal class Hooman
    {
        protected string name;
        protected string address;
        protected string email;
        protected string phoneNumber;

        public virtual void Show()
        {
            Console.WriteLine("Ten :" + this.name);
            Console.WriteLine("Dia chi :" + this.address);
            Console.WriteLine("Email :" + this.email);
            Console.WriteLine("SDT :" + this.phoneNumber);
        }

        public Hooman(string name, string address, string email, string phoneNumber)
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

    }

    class NhanVien : Hooman
    {
        protected string BangCap;

        public NhanVien(string name, string address, string email, string phoneNumber, string bangCap) 
            : base(name, address, email, phoneNumber)
        {
            this.BangCap = bangCap;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Bang Cap:" + this.BangCap);
        }

    }

    class KeToan : NhanVien
    {
        private int Luong;
        public KeToan(string name, string address, string email, string phoneNumber, string bangCap, int luong) : base(name, address, email, phoneNumber, bangCap)
        {
            this.Luong = luong;
        }

        public override void Show()
        {
            Console.WriteLine("Ten :" + this.name);
            Console.WriteLine("Dia chi :" + this.address);
            Console.WriteLine("Email :" + this.email);
            Console.WriteLine("SDT :" + this.phoneNumber);
            Console.WriteLine("Bang Cap :" + this.BangCap);
            Console.WriteLine("Luong :" + this.Luong);
        }
    }


}
