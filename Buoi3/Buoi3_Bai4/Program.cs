namespace Buoi3_Bai4
{
    internal class Program
    {
        const double VAT = 0.1;

        static double Tinhtien (ref double giagoc)
        {
            double tienvat = giagoc * VAT;
            double giasauthue = giagoc + tienvat;
            giagoc = (int)giasauthue;
            return giasauthue;

        }

        static void Main(string[] args)
        {
            Console.Write("Nhap gia goc:");
            double giagoc = Convert.ToDouble(Console.ReadLine());
            double giasauthue = Tinhtien(ref giagoc);
            Console.WriteLine($"Gia sau thue da lam tron: {giagoc}, Gia sau thue: {giasauthue}");
        }
    }
}
