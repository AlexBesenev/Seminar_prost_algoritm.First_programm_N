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

            int n_vichet = n; // Для цикла деления на Pow
            int n_while = n; // Для цикла деления на 10
            int quantity_num = 0; // количество знаков
            int Pow = 1; // 10 в степени quantity_num
            if (n > 9)  // отсеем 1 значные числа
            {
                while (0 < n_while) // узнаем скольки значное число делением на 10, до тех пор пока n = 0.
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
                // Максимальное значение Pow = число 10^ quantity_num (кол-ва знаков)
                for (int i = 1; i < quantity_num; i++)
                {
                    Pow *= 10;
                }
                /* Работа Главного цикл Пример: 
                1) 1234 / 1000(pow)= CW (1,) ; 
                2) 1234 - 1*pow = 234;
                3) 1000/10= 100 - newPow;
                4) repit
                */
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