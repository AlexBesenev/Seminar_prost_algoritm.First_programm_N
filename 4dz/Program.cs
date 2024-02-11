/*
программу, которая на вход принимает натуральное число N,
 а на выходе показывает его цифры через запятую.
Решить с обратным порядком цифр, в эталонном решении такой вариант.
*/

int n = 123456;
int n_while = n;
int quantity_num = 1; // количество знаков
if (n > 9)
{
    while (quantity_num < n_while) // узнаем скольки значное число
    {
        quantity_num++;
        n_while /= 10;
    }
    // число 10^кол-ва знаков
    int Pow = 1;
    for (int i = 1; i < quantity_num; i++)
    {
        Pow *= 10;
    }
    // System.Console.WriteLine("Деление на "+ Pow);
    for (int i = Pow; i > 0; i /= 10)
    {
        int vichet = n/i;
        if(n >= 10)
        {
            System.Console.Write(vichet +",");
        }
        else 
        {
            System.Console.Write(vichet);
        }
        n = n - (vichet*i);
    
    }
}
else 
{
    System.Console.WriteLine(n);
}