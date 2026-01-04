namespace Buoi3_Bai2
{
    internal class Program
    {
        const int WH_TO_KWH = 1000;
        const int PRICE_PER_KWH = 2500;

        static double Tientiendien(ref int sodien)
        {
            double kwh = (double)sodien / WH_TO_KWH;
            double tongtien = kwh * PRICE_PER_KWH;
            sodien = (int)Math.Round(kwh);
            return tongtien;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so dien (wh): " );
            int sodien = Convert.ToInt32(Console.ReadLine());
            double tongtien = Tientiendien(ref sodien);
            Console.WriteLine($"So dien (kwh): {sodien}, Tong tien dien: {tongtien}");
        }
    }
}
