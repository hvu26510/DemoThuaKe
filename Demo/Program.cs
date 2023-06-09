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
            #region
            //List<SinhVien> sv = listSV.Cast<SinhVien>().Where(s => s.getMaSV() == 1).Take(1).ToList();
            //TinhTrungBinh(listSV);

            //listSV.Sort(Comparer<SinhVien>.Create((sv1, sv2) => sv2.getDiem().CompareTo(sv1.getDiem())));
            //foreach (SinhVien sv in listSV)
            //{
            //    sv.Xuat();
            //}

            //SapXep(listSV);

            #endregion

            FindByMaSVandUpdate(ref listSV, 6);

            foreach(SinhVien sv in listSV)
            {
                sv.Xuat();
            }

            Console.ReadLine();
        }

        static void SortArrayList(ArrayList listSV)
        {
            listSV.Sort(Comparer<SinhVien>.Create((sv2, sv1) => sv1.getDiem().CompareTo(sv2.getDiem())));
            foreach (SinhVien sv in listSV)
            {
                sv.Xuat();
            }

        }
        public double TinhDiemTB(ref ArrayList listSV)
        {
            double diemTB = 0;
            double tong = 0;
            foreach (SinhVien sv in listSV)
            {
                tong = tong + sv.getDiem();
            }

            diemTB = tong/listSV.Count;
            return diemTB;
        }


        static void SapXep(ArrayList list)
        {

            List<SinhVien> listSV = list.Cast<SinhVien>().ToList();
            for (int i = 0; i < listSV.Count; i++)
            {

                for (int j = i + 1; j < listSV.Count; j++)
                {
                    if (listSV[i].getDiem() < listSV[j].getDiem())
                    {
                        var temp = listSV[i];
                        listSV[i] = listSV[j];
                        listSV[j] = temp;
                    }
                }
            }

            foreach (SinhVien sv in listSV)
            {
                sv.Xuat();
            }



        }


        static List<SinhVien> SapXep1(ArrayList list)
        {
            List<SinhVien> sv = list.Cast<SinhVien>().ToList();

            sv.Sort((sv1, sv2) => sv1.getDiem().CompareTo(sv2.getDiem()));
            sv.Reverse();
            return sv;
        }

        static void Print5Highest(ArrayList list)
        {
            List<SinhVien> sv = list.Cast<SinhVien>().ToList();

            sv.Sort((sv1, sv2) => sv1.getDiem().CompareTo(sv2.getDiem()));
            sv.Reverse();

            for (int i = 0; i < sv.Count; i++)
            {
                if (i == 5)
                {
                    break;
                }
                else
                {
                    sv[i].Xuat();
                }
            }
        }

        static void TinhTrungBinh(ArrayList list)
        {
            List<SinhVien> sv = list.Cast<SinhVien>().ToList();
            double tong = 0;

            for (int i = 0; i < sv.Count; i++)
            {
                tong += sv[i].getDiem();
                
            }

            double diemTB = tong / sv.Count;
            Console.WriteLine(diemTB);
        }

        static SinhVien FindByMaSVandUpdate(ref ArrayList list, int MaSV)
        {
            foreach (SinhVien sv in list)
            {
                if (sv.getMaSV() == MaSV)
                {
                    sv.Xuat();
                    int index = list.IndexOf(sv);
                    SinhVien newSV = new SinhVien();
                    newSV.Nhap();
                    list[index] = newSV;

                    return sv;
                }
            }
            return null;

        }

        static void addDataDemo(ref ArrayList list)
        {
            SinhVien sv1 = new SinhVien(1, "abc", 10, "abc@email");
            SinhVien sv2 = new SinhVien(2, "def", 5, "def@email");
            SinhVien sv3 = new SinhVien(3, "GH", 7, "gh@email");
            SinhVien sv4 = new SinhVien(4, "YK", 9, "yk@email");
            SinhVien sv5 = new SinhVien(5, "YK", 9, "yk@email");
            SinhVien sv6 = new SinhVien(6, "YK", 3, "yk@email");
            list.Add(sv1);
            list.Add(sv2);
            list.Add(sv3);
            list.Add(sv4);
            list.Add(sv5);
            list.Add(sv6);

        }
        static SinhVien getValue(ref ArrayList list)
        {
            foreach (SinhVien item in list)
            {
                if (item.getName() == "abc")
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
