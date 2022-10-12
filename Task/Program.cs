namespace Lessont4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Введите первое число!");
            string str1 = Console.ReadLine();
            int.TryParse(str1, out int result1);

            Console.WriteLine("Введите второе число!");
            string str2 = Console.ReadLine();
            int.TryParse(str2, out int result2);

            MaxValue(result1, result2);

            MinValue(result1, result2);

            TrySumIfOdd(5, 4, out sum);
        }
        static void MaxValue(int a, int b)
        {
            if (a > b)
                Console.WriteLine(a);
        }

        static void MinValue(int a, int b)
        {
            if (a < b)
                Console.WriteLine(b);
        }

        static bool TrySumIfOdd(int a, int b, out int sum)
        {

            sum = a + b;
            if (sum % 2 == 0)
                return true;
            else
                Console.WriteLine($"Сума чисел {sum}");
            return false;


        }
        static void MaxValue(int a, int b, int c) { }
        static void MaxValue(int a, int b, int c, int x) { }
        static void MinValue(int a, int b, int c) { }
        static void MinValue(int a, int b, int c, int x) { }




    }



}



