// Напишите программу, которая на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");

int n = int.Parse(Console.ReadLine());

if (n<0)
{
    n=-n;
}
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
        Console.WriteLine(i);