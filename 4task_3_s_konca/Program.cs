/*
Напишите программу, которая выводит третью с конца
цифру заданного числа или сообщает, что третьей цифры
нет.
456 => 4
7812 => 8
91 => Третьей цифры нет
*/

int number = 9875;
// int del = number / 100;
// int ostatok = del % 10;
// if (del > 0)
// {
//     if (ostatok == 0)
//     {
//         System.Console.WriteLine(del);
//     }
//     else
//     {
//         System.Console.WriteLine(ostatok);
//     }
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine(number / 100 % 10);
}