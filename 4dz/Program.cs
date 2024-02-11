/*
программу, которая на вход принимает натуральное число N,
 а на выходе показывает его цифры через запятую.
Решить с обратным порядком цифр, в эталонном решении такой вариант.
*/
using System;
class Program
{
    static void Main()
    {
        Console.Write("Привет, эта программа перечислит все цифры натурального числа через запятую. Если хочешь начать введи 1: ");
        int otvet = Convert.ToInt32(Console.ReadLine());
        while (otvet == 1)
        {
            Console.Write("Введите любое число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int n_vichet = n;
            int n_while = n;
            int quantity_num = 0; // количество знаков
            int Pow = 1;
            if (n > 9)
            {
                while (0 < n_while) // узнаем скольки значное число
                {
                    quantity_num++;
                    n_while /= 10;
                }
                Console.Write("Введи 1 если хотите узнать скольки значное число n : ");
                int how_quan_num = Convert.ToInt32(Console.ReadLine());
                if (how_quan_num == 1)
                {
                    System.Console.WriteLine("Ваше число " + quantity_num + " значное.");
                }
                // число 10^кол-ва знаков
                for (int i = 1; i < quantity_num; i++)
                {
                    Pow *= 10;
                }
                // System.Console.WriteLine("Деление на "+ Pow);
                while (Pow > 0)
                {
                    int vichet = n_vichet / Pow;
                    if (n_vichet >= 10)
                    {
                        System.Console.Write(vichet + ",");
                    }
                    else
                    {
                        if (vichet == 0 && Pow > 1)
                        {
                            System.Console.Write(vichet + ",");
                        }
                        else 
                        {
                            System.Console.WriteLine(vichet);
                        }
                    }
                    n_vichet = n_vichet - (vichet * Pow);
                    Pow /= 10;
                }
            }
            else
            {
                System.Console.WriteLine("Число 1 значное: "+n);
            }
            Console.Write("Введи 1, если хочешь повторить: ");
            otvet = Convert.ToInt32(Console.ReadLine());
        }
    }
}