using System.Runtime.CompilerServices;

namespace ktgk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap N: ");
            int n = int.Parse(Console.ReadLine());
            List<HoGiaDinh> listHoGiaDinh = new List<HoGiaDinh>();
            List<Nguoi> listNguoi = new List<Nguoi>();
            List<KhuPho> listKhuPho = new List<KhuPho>
            {
                new KhuPho ( 1, "Khu pho A" ),
                new KhuPho ( 2, "Khu pho B" ),
                new KhuPho ( 3, "Khu pho C" )
            };

            for ( int i = 1; i <= n; i++ )
            {
                HoGiaDinh hogiadinh = new HoGiaDinh();
                Console.WriteLine($"Nhap ho gia dinh thu {i}");
                hogiadinh.nhap();
                listHoGiaDinh.Add(hogiadinh);
                // nhap tung thanh vien trong ho gia dinh
                for ( int j = 1; j <= hogiadinh.soThanhVien; j++)
                {
                    Nguoi nguoi = new Nguoi();
                    Console.WriteLine($"Nhap thanh vien thu {j}");
                    nguoi.nhap(hogiadinh.iDHoGiaDinh);
                    listNguoi.Add(nguoi);
                }
            }

            Console.WriteLine("Cac ho gia dinh:");
            foreach(var item in listHoGiaDinh)
            {
                item.hienThi();
            }

            // con trai >= 2
            var soTraiLon2 = listHoGiaDinh.Where(x => x.soTrai >= 2);
            Console.WriteLine("Cac ho gia dinh co so con trai lon hon 2:");
            if (soTraiLon2.Any())
            {
                foreach (var item in soTraiLon2)
                {
                    item.hienThi();
                }
            }
            else
            {
                Console.WriteLine("  Khong co!");
            }
            

            // so con >=5 && <=10
            var soCon5Den10 = listHoGiaDinh.Where((x) => (x.soTrai + x.soGai) >= 5 && (x.soTrai + x.soGai) <= 10);
            Console.WriteLine("Cac ho gia dinh co so con tu 5 den 10:");
            if (soCon5Den10.Any())
            {
                foreach (var item in soCon5Den10)
                {
                    item.hienThi();
                }
            }
            else
            {
                Console.WriteLine("Khong co!");
            }
            

            // tong so thanh vien trong khu pho
            var tongSoThanhVienKhuPho = from hgd in listHoGiaDinh
                                        join kp in listKhuPho on hgd.iDKhuPho equals kp.iDKhuPho
                                        group hgd by kp.ten into khuPho
                                        select new
                                        {
                                            ten = khuPho.Key,
                                            tong = khuPho.Sum(x => x.soThanhVien)
                                        };
            Console.WriteLine("Tong so thanh vien trong khu pho");
            foreach(var item in tongSoThanhVienKhuPho)
            {
                Console.WriteLine($"  Khu pho: {item.ten}, tong: {item.tong}");
            }

            // ho gia dinh co nguoi ten "Hung"
            var nguoiTenHung = listNguoi.Where(x => x.ten.Contains("Hung"));
            var hoGiaDinhTenHung = from hgd in listHoGiaDinh
                                   join nth in nguoiTenHung on hgd.iDHoGiaDinh equals nth.iDHoGiaDinh
                                   group nth by nth.iDHoGiaDinh into hogiadinh
                                   select new
                                   {
                                       id = hogiadinh.Key,
                                       nguoi = hogiadinh.ToList()
                                   };
            Console.WriteLine("Cac ho gia dinh co nguoi ten Hung:");
            if(hoGiaDinhTenHung.Any())
            {
                foreach (var item in hoGiaDinhTenHung)
                {
                    Console.WriteLine($"ID ho gia dinh: {item.id}");
                    foreach (var item2 in item.nguoi)
                    {
                        Console.WriteLine($"  CMND: {item2.cMND}, ten: {item2.ten}, tuoi: {item2.tuoi}, nghe nghiep: {item2.ngheNghiep}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong co!");
            }

            // thong ke so con trai, gai trong khu pho
            var tongSoTraiGaiKhuPho = from hgd in listHoGiaDinh
                                    join kp in listKhuPho on hgd.iDKhuPho equals kp.iDKhuPho
                                    group hgd by kp.ten into khuPho
                                    select new
                                    {
                                        ten = khuPho.Key,
                                        tongTrai = khuPho.Sum(x => x.soTrai),
                                        tongGai = khuPho.Sum(x => x.soGai)
                                    };
            Console.WriteLine("Thong ke so con trai, gai trong khu pho");
            foreach(var item in tongSoTraiGaiKhuPho)
            {
                Console.WriteLine($"  Khu pho: {item.ten}, tong con trai: {item.tongTrai}, tong con gai: {item.tongGai}");
            }

            Console.ReadKey();
        }
    }
}
