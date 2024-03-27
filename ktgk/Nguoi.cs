using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktgk
{
    internal class Nguoi
    {
        public string cMND {  get; set; }
        public string ten {  get; set; }
        public int tuoi { get; set; }
        public string ngheNghiep { get; set; }
        public int iDHoGiaDinh { get; set; }

        public Nguoi(string cMND, string ten, int tuoi, string ngheNghiep, int iDHoGiaDinh)
        {
            this.cMND = cMND;
            this.ten = ten;
            this.tuoi = tuoi;
            this.ngheNghiep = ngheNghiep;
            this.iDHoGiaDinh = iDHoGiaDinh;
        }

        public Nguoi()
        {
        }

        public void nhap()
        {
            Console.Write("  Nhap CMND: ");
            this.cMND = Console.ReadLine();
            Console.Write("  Nhap ten: ");
            this.ten = Console.ReadLine();
            Console.Write("  Nhap tuoi: ");
            this.tuoi = int.Parse(Console.ReadLine());
            Console.Write("  Nhap nghe nghiep: ");
            this.ngheNghiep = Console.ReadLine();
            Console.Write("  Nhap ID ho gia dinh: ");
            this.iDHoGiaDinh = int.Parse(Console.ReadLine());
        }
        public void nhap(int iDHoGiaDinh)
        {
            Console.Write("  Nhap CMND: ");
            this.cMND = Console.ReadLine();
            Console.Write("  Nhap ten: ");
            this.ten = Console.ReadLine();
            Console.Write("  Nhap tuoi: ");
            this.tuoi = int.Parse(Console.ReadLine());
            Console.Write("  Nhap nghe nghiep: ");
            this.ngheNghiep = Console.ReadLine();
            //Console.Write("Nhap ID ho gia dinh: ");
            this.iDHoGiaDinh = iDHoGiaDinh;
        }
        public void hienThi()
        {
            Console.WriteLine($"  CMND: {this.cMND}, Ten: {this.ten}, Tuoi: {this.tuoi}, Nghe nghiep: {this.ngheNghiep}, ID ho gia dinh: {this.iDHoGiaDinh}");
        }
    }
}
