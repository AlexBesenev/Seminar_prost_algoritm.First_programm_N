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
Console.Write("Начнем?1 - да, 0 - нет: ");
int otvet = Convert.ToInt32(Console.ReadLine());
while (otvet == 1)
{
    Console.Write("Введите число n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    // int n = 9;
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
            // число 10^кол-ва знаков
        for (int i = 1; i < quantity_num; i++)
        {
            Pow *= 10;
        }
        // System.Console.WriteLine("Деление на "+ Pow);
        while (Pow > 0)
        {
            int vichet = n_vichet/Pow;
            if(n_vichet >= 10)
            {
                System.Console.Write(vichet +",");
            }
            else 
            {
                System.Console.WriteLine(vichet);
            }
            n_vichet = n_vichet - (vichet*Pow);
            Pow /=10;
        }
        // for (int i = Pow; i > 0; i /= 10)
        // {
        //     int vichet = n/i;
        //     if(n >= 10)
        //     {
        //         System.Console.Write(vichet +",");
        //     }
        //     else 
        //     {
        //         System.Console.Write(vichet);
        //     }
        //     n = n - (vichet*i);
    }
    else 
    {
        System.Console.WriteLine(n);
    }
    Console.Write("Ввести новое число?1 - да, 0 - нет: ");
    otvet = Convert.ToInt32(Console.ReadLine());}
    }
}