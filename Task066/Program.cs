// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите целое число N:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число M:");
int number2 = Convert.ToInt32(Console.ReadLine());


int SumNumbersInRange(int n, int m)
{
    int min = n < m ? n : m;
    int max = m > n ? m : n;
    
    if (min == max)
        return max;
    return max + SumNumbersInRange(min, max - 1);
}

int result = SumNumbersInRange(number1, number2);
Console.WriteLine($"Сумма элементов от {number1} до {number2} = {result}");
