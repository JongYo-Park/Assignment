namespace 박종요_과제_1._계산기_클래스_만들기
{
    internal class Program
    {
        public class MyCalculator()
        {
            public static double Add(double x, double y)
            {
                return x + y;
            }
            public static double Subtract(double x, double y)
            {
                return x - y;
            }
            public static double Multiply(double x, double y)
            {
                return x * y;
            }
            public static double Divide(double x, double y)
            {
                if (y == 0)
                {
                    Console.WriteLine("ERROR!");
                }
                return x / y;
            }
            public static double Squared(double x, double y)
            {
                return Math.Pow(x, y);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"{MyCalculator.Add(4, 2)}");
            Console.WriteLine($"{MyCalculator.Subtract(4, 2)}");
            Console.WriteLine($"{MyCalculator.Multiply(4, 2)}");
            Console.WriteLine($"{MyCalculator.Divide(4, 0)}");
            Console.WriteLine($"{MyCalculator.Squared(4, 2)}");
        }
    }
}
