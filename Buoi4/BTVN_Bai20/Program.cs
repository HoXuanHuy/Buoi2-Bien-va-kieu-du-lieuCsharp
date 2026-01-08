namespace BTVN_Bai20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n=0;
            int m=0;
            Console.Write("Nhập số nguyên dương:");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập lại giá trị");
            }
            while (n != 0)
            {
                int a = n % 10;
                m = m*10 +a;
                n= n / 10;
            }
            Console.WriteLine($"Số đảo ngược: {m}");



        }
    }
}
