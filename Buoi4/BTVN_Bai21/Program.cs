namespace BTVN_Bai21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int h= 0;
            Console.Write("Nhập chiều cao kim tự tháp:");
            while (!int.TryParse(Console.ReadLine(), out h) || h < 0)
            {
                Console.WriteLine("Vui lòng nhập lại giá trị");

            }
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= (2*h-1); j++)
                {
                    if (j >= (h - (i - 1)) && j <= (h + (i - 1)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
