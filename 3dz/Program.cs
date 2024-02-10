/*
программу, которая принимает на вход целое число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
*/

int n = 56;
if (n > 10 && n < 99)
{
    int num1 = n / 10;
    int num2 = n % 10;

    if (num1 > num2)
    {
        System.Console.WriteLine(num1);
    }
    else
    {
        System.Console.WriteLine(num2);
    }
}
else
{
    System.Console.WriteLine("Число не в отрезке 10-99");
}
