using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktgk
{
    internal class HoGiaDinh
    {
        public int iDHoGiaDinh {  get; set; }
        public int soThanhVien { get; set; }
        public int soTrai {  get; set; }
        public int soGai { get; set; }
        public int soNha {  get; set; }
        public int iDKhuPho { get; set; }

        public HoGiaDinh(int iDHoGiaDinh, int soThanhVien, int soTrai, int soGai, int soNha, int iDKhuPho)
        {
            this.iDHoGiaDinh = iDHoGiaDinh;
            this.soThanhVien = soThanhVien;
            this.soTrai = soTrai;
            this.soGai = soGai;
            this.soNha = soNha;
            this.iDKhuPho = iDKhuPho;
        }

        public HoGiaDinh()
        {
        }

        public void nhap()
        {
            Console.Write("Nhap ID ho gia dinh: ");
            this.iDHoGiaDinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thanh vien: ");
            this.soThanhVien = int.Parse(Console.ReadLine());
            Console.Write("Nhap so con trai: ");
            this.soTrai = int.Parse(Console.ReadLine());
            Console.Write("Nhap so con gai: ");
            this.soGai = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nha: ");
            this.soNha = int.Parse(Console.ReadLine());
            Console.Write("Nhap ID khu pho: ");
            this.iDKhuPho = int.Parse(Console.ReadLine());
        }
        public void hienThi()
        {
            Console.WriteLine($"  ID ho gia dinh: {this.iDHoGiaDinh}, so thanh vien: {this.soThanhVien}, so con trai: {this.soTrai}, so con gai: {this.soGai}, so nha: {this.soNha}, ID khu pho: {this.iDKhuPho}");
        }
    }
}
