using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[7];

        // Вводим семь значений от пользователя
        Console.WriteLine("Введите семь целых чисел:");
        for (int i = 0; i < 7; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbers[i] = num;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                i--; 
            }
        }
        
        int count = 0;
        foreach (int number in numbers)
        {
            if (number > 0 && number % 3 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество положительных чисел, делящихся на 3 без остатка: {count}");
    }
}
