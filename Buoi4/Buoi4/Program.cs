namespace Buoi4
{
    internal class Program
    {

        #region Params
        static int Total(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum+= number;
            }
            return sum;
        }

        #endregion

        static void Main(string[] args)
        {
            //int result = Total(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            //Console.Write($"tong:{result}");

            int age = 6;
            switch (age)
            {
                case 1:
                    Console.WriteLine("You are 1 year old.");
                    break;
                case 2:
                    Console.WriteLine("You are 2 year old.");
                    break;
                case 3:
                    Console.WriteLine("You are 3 year old.");
                    break;
                case 4:
                    Console.WriteLine("You are 4 year old.");
                    break;
                case 5:
                    Console.WriteLine("You are 5 year old.");
                    break;
                default:
                    Console.WriteLine("You are older than 5 years.");
                    break;
            }

        }
        }
    }
}
