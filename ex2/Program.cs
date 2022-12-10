// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Enter number a: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Enter number b: ");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;
int min = numberA;

if (numberA > max) 
{
    max = numberA; 
    min = numberB;
}
if (numberB > max) 
{
    max = numberB;
    min = numberA;
}

Console.Write ("max = ");
Console.WriteLine (max);

Console.Write ("min = ");
Console.WriteLine (min);