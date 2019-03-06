using System;

namespace ConsoleApp_for_unit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Коля, как дела? Нажми любую кнопку, чтобы закончить меня.");
            //Console.ReadLine();
            Console.WriteLine("Введи два числа, чтобы продолжить игру.");

            string a = Console.ReadLine();
            string b = Console.ReadLine();
            
            int num1 = Int32.Parse(a);
            int num2 = Int32.Parse(b);

            int result = num1 + num2;
            Console.WriteLine(result);
            
            result = Int32.MaxValue;
            Console.WriteLine(result);

            result = num1 * num2;
            Console.WriteLine(result);

            result = (num1 * num2 / 2);
            Console.WriteLine(result);

            double average = (double) (num1 + num2) / 2;
            Console.WriteLine(average);

        }
    }
}