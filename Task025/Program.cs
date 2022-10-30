// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int pow = Convert.ToInt32(Console.ReadLine());

int riseToPow = RiseToPow(num, pow);
Console.WriteLine($"Число {num} в степени {pow} будет равно {riseToPow}");


int RiseToPow(int number, int count)
{
    int result = 1;
    for (int i = 1; i <= count; i++)
    {
        result = result * number;
    }
    return result;
}

