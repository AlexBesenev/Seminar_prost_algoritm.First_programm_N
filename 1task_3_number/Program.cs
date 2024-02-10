/* Напишите программу, которая принимает на вход
трёхзначное число и удаляет вторую цифру этого
числа.
Примеры
a = 256 => 26
a = 891 => 81
*/

int a = 891;
int first_number = a / 100;
double second_number = a % 10;
System.Console.Write($"{first_number}" + $"{second_number}");