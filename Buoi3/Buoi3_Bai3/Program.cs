namespace Buoi3_Bai3
{
    internal class Program
    {
        const int MIN_PER_HOUR = 60;
        const int SALARY_PER_HOUR = 45000;

        static double TinhLuong(ref int totalMinutes)
        {
            double hours = (double)totalMinutes / MIN_PER_HOUR;
            double totalSalary = hours * SALARY_PER_HOUR;
            totalMinutes = (int)Math.Round(hours);
            return totalSalary;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhap tong so phut lam viec:");
            int totalMinutes = Convert.ToInt32(Console.ReadLine());
            double totalSalary = TinhLuong(ref totalMinutes);
            Console.WriteLine($"So gio lam viec: {totalMinutes}, Tong luong: {totalSalary}");

        }
    }
}
