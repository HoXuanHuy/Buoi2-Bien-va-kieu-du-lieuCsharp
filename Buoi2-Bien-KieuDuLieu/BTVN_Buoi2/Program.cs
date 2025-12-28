namespace BTVN_Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Bai2 overflow
            byte a = 254;
            Console.WriteLine(a);
            a++;
            Console.WriteLine( a);
            a++;
            Console.WriteLine(a);

            sbyte b = 126;
            Console.WriteLine(b);
            b++;
            Console.WriteLine(b);
            b++;
            Console.WriteLine(b);
            */

            /* //Bai 3 decimal
            decimal m1 = 2112334.45m;
            decimal m2 = 3223456.55m;
            decimal mul = m1 * m2;
            Console.WriteLine(mul);
            */

            /*// Bai 4 boxing unboxing
            int c = 78;
            object obj = c; // boxing
            Console.WriteLine("Gia tri cua obj: " + obj);
            int d = (int)obj; // unboxing
            Console.WriteLine("Gia tri cua d: " + d);
            */

            //Bai 5 so sanh float double decimal
            float f = 1f / 3f;
            double dou = 1d / 3d;
            decimal dec = 1m / 3m;
            Console.WriteLine("Float:"+f);
            Console.WriteLine("Double:" + dou);
            Console.WriteLine("Decimal:" + dec);


        }
    }
}
