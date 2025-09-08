using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //арифметичні_операції
        int a = 10;
        double b = 3.5;
        Console.WriteLine($"Сума: {a + b}");
        Console.WriteLine($"Добуток: {a * b}");

        //логічні_оператори+умовні
        if (a > 5 && b < 10)
        {
            Console.WriteLine("все гуд");
        }
        else if (a == 10 || b > 5)
        {
            Console.WriteLine("майже гуд");
        }
        else
        {
            Console.WriteLine("інше гуд");
        }

        switch (a)
        {
            case 5:
                Console.WriteLine("a = 5");
                break;
            case 10:
                Console.WriteLine("a = 10");
                break;
            default:
                Console.WriteLine("інше значення");
                break;
        }

        //масив+цикли
        int[] numbers = { 1, 2, 3, 4, 5 };
        List<string> names = new List<string> { "Артем", "Дмитро", "Макс" };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"for: {numbers[i]}");
        }

        int j = 0;
        while (j < 3)
        {
            Console.WriteLine($"while: {j}");
            j++;
        }

        int k = 0;
        do
        {
            Console.WriteLine($"do-while: {k}");
            k++;
        } while (k < 2);

        foreach (var name in names)
        {
            Console.WriteLine($"foreach: {name}");
        }

        //виклик_класу 
        Class obj1 = new Class();
        Class obj2 = new Class("Romanov Artem");

        obj1.PublicMethod();
        obj2.PublicMethod();
    }
}
