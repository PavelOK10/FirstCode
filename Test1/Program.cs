using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (x < y)
            {
                Console.WriteLine("Второе число больше первого");
            }
            else 
            {
                Console.WriteLine("Числа равны");
            }
        }
    }
}