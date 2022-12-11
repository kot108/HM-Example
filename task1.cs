

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1");
string A = Console.ReadLine()!;
Console.WriteLine("Введите число 2");
string B = Console.ReadLine()!;

int ParseA = int.Parse(A);
int ParseB = int.Parse(B);

if (ParseA > ParseB)
{
    Console.WriteLine(ParseA);
}
else
{
    Console.WriteLine("Максимальное число ="); 
   
}
Console.WriteLine (ParseB);
