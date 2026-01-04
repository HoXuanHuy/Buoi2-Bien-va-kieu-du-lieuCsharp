namespace Buoi3_Bai1
{
    internal class Program
    {
        const double VAT = 0.1;

        static (double, int) Nhapdongiavasoluong()
        {
            Console.Write("Nhap don gia: ");
            double dongia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so luong: ");
            int soluong = Convert.ToInt32(Console.ReadLine());
            return (dongia, soluong);
        }
        static (double,double) TinhTien( double dongia, int soluong, double VAT)
        {
            double thanhtien = dongia * soluong;
            double tienvat = thanhtien * VAT;
            double tongtien = thanhtien + tienvat;
            return (tienvat, tongtien);
        }

        static void TinhTienv2(double dongia, int soluong, double VAT, out double tongtien, out double tienvat)
        {
            double thanhtien = dongia * soluong;
            tienvat = thanhtien * VAT;
            tongtien = thanhtien + tienvat;
        }
        static int Tangsoluong( ref int soluong)
        {
            soluong++;
            return soluong;
        }

        static void Main(string[] args)
        {
            var (dongia, soluong) = Nhapdongiavasoluong();
            //Tangsoluong(ref soluong);
            var (tienvat, tongtien) = TinhTien(dongia, soluong, VAT);
            //TinhTienv2( dongia, soluong, VAT, out double tongtien, out double tienvat);
            int tongtiennew = (int)tongtien;
            Console.WriteLine($"Tien VAT: {tienvat}, Tong tien: {tongtiennew}");
        }
    }
}
