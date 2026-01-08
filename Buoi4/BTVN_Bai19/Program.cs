namespace BTVN_Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int sum = 0;
            int n;
            Console.Write("Nhập số nguyên dương:");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập lại giá trị");
            }

            while (n !=0) 
            {
                int a = n % 10;
                sum += a;
                n = n / 10;
            }
            Console.WriteLine($"Tổng các chữ số: {sum}");
        }
    }
}
