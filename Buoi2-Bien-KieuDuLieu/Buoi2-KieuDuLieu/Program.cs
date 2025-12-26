namespace Buoi2_KieuDuLieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Khai báo và khởi tạo các kiểu dữ liệu
            char a= 'H';
            int i = 123;
            short s = 56;
            long l = 3443;
            uint ui = 945;
            ushort us = 716;
            ulong ul = 3624573;
            double d = 8.358674532;
            float f = 3.7330645f;
            decimal dec = 389.5m;

            //In ket qua
            Console.WriteLine("char: "+a);
            Console.WriteLine("integer: "+i);
            Console.WriteLine("short: "+s);
            Console.WriteLine("long: "+l);
            Console.WriteLine("double: "+d);
            Console.WriteLine("float: "+f);
            Console.WriteLine("decimal: "+dec);
            Console.WriteLine("unsigned integer: " + ui);
            Console.WriteLine("unsigned short: " + us);
            Console.WriteLine("unsigned long: " + ul);
            */


            unsafe
            {
                // Khai báo biến 
                int n = 10;
                // Lưu địa chỉ của biến n vào biến con trỏ p 
                int* p = &n;
                Console.WriteLine("Value: {0}", n);
                Console.WriteLine("Address: {0}", (int)p);
            }

        }
    }
}
