// Задача 2: 
// Напишите программу, которая 
// на вход принимает два числа 
// и 
// выдаёт, какое число большее, а какое меньшее.


Console.Write("Ведите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
int max = numA;
int min = numB;
if (numA != numB)
{
    if (numB > numA)
    {
        max = numB;
        min = numA;
        Console.WriteLine($"{max} является большим числом, а {min} - меньшим");
    }
    else
        Console.WriteLine($"{max} является большим числом, а {min} - меньшим");
}
else
    Console.Write("Числа равны");
