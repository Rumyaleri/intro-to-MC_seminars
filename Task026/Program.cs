// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumbersCount(int num)
{
    int count = default;
    while(num > 0)
    {
        num /=10;
        count++;
    }
    return count;
}

int numbersCount = NumbersCount(number);
Console.WriteLine($"Количество цифр в числе {number} -> {numbersCount}");