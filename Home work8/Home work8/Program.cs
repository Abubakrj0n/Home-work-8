// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.Write("Шумораи бутуни N ворид кунед (> 0):");
        int N = int.Parse(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Шумораи N бояд аз 0 зиёд бошад!");
            return;
        }

        double factorial = 1;
        int number = N;

        while (number > 0)
        {   
            factorial *= number;
            number -= 2; 
        }

        Console.WriteLine($"Дучанд омили {N}!! = {factorial}");
    }
}
