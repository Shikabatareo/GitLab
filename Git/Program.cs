using System;

namespace Git
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a;
           Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Ввести А");
            Console.WriteLine("2. Ввести В");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите А:");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Вы ввели: " + a);
                    break;
                case "2":
                    Console.WriteLine("Введите В:");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Вы ввели: " + b);
                    break;
                case "3":
                    Console.WriteLine("Введите А и В для операции '+'");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + (x + y));
                    break;
                case "4":
                    Console.WriteLine("Введите А и В для операции '-'");
                    int p = int.Parse(Console.ReadLine());
                    int q = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + (p - q));
                    break;
                case "5":
                    Console.WriteLine("Введите А и В для операции '*'");
                    int m = int.Parse(Console.ReadLine());
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + (m * n));
                    break;
                case "6":
                    Console.WriteLine("Введите А и В для операции '/'");
                    int c = int.Parse(Console.ReadLine());
                    int d = int.Parse(Console.ReadLine());
                    if (d == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль");
                    }
                    
                    else
                    {
                        Console.WriteLine("Результат: " + ((double)c / d));
                    }
                    break;
                default:
                    Console.WriteLine("Некорректный выбор операции");
                    break;
            }
         
            Console.ReadLine();
        }
    }
}