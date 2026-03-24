// Програма, яка запитує у користувача число і виводить результат ділення цього числа на числа від 1 до 10 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        double number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nРезультати ділення:");
        for (int i = 1; i <= 10; i++)
        {
            double result = number / i;
            Console.WriteLine($"{number} / {i} = {result}");
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}