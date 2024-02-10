/*Напишите программу, которая принимает на вход трёхзначное
число и возводит вторую цифру этого числа в степень, равную
третьей цифре.
Примеры
487 => 8^7 = 2 097 152
254 => 5^4 = 625
617 => 1

Используя функцию Math. - математика, Pow - возведение числа в степень
double result = Math.Pow(8, 7);
System.Console.WriteLine(result);*/

// int a = 487;
// double first_number = a / 10 % 10;
// double pow = a % 10;
// double c = 1;
// int i = 0;


// while (i < pow)
// {
//     c = c * first_number;
//     i++;
// }
// System.Console.WriteLine(c);


int a = 481;
int first_number = a / 10 % 10;
int pow = a % 10;
int c = 1;
for (int i = 0; i < pow; i++)
{
    c*=first_number;
}
System.Console.WriteLine(c);