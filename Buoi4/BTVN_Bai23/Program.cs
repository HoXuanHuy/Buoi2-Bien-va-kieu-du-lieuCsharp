namespace BTVN_Bai23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n;
            int m = 0;
            Console.Write("Nhập số nguyên dương:");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Vui lòng nhập lại giá trị");
            }
            int b = n;
            while (n != 0)
            {
                int a = n % 10;
                m = m * 10 + a;
                n = n / 10;
            }
            if (b == m)
            {
                Console.WriteLine($"{b} là số palindrome");
            }
            else
            {
                Console.WriteLine($"{b} không phải là số palindrome");
            }
        }
    }
}
