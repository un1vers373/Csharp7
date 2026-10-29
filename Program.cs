using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Сумма чисел от 1 до 10: " + sum);
        }
    }
}