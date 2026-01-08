namespace BTVN_Bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            uint n = 0;
            uint m = 1;
            Console.Write("Nhập số nguyên dương:");
            while (!uint.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Vui lòng nhập lại giá trị");
            }
            for (uint i = n; i >0; i--)
            {
                m = m * i;
            }
            Console.WriteLine($"Giai thừa của {n} là: {m}");
        }
    }
}
