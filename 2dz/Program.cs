/* программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
 в которой находится эта точка.
*/ 

int x = -1;
int y = -22;
if(x>0 && y > 0)
{
    System.Console.WriteLine("1");
}
if( x<0 && y>0)
{
    System.Console.WriteLine("2");
}
if( x<0 && y<0)
{
    System.Console.WriteLine("3");
}
if( x>0 && y<0)
{
    System.Console.WriteLine("4");
}