// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers (num);
Console.WriteLine($"Сумма чисел от 1 до {num} равна {sumNumbers}");

int SumNumbers(int num)
{
    int sum = default;
    // вместо ноля можно написать default - значение не определено
   for (int i = 1; i <= num; i++)
   {
    sum += i;
    // sum = sum + i
   } 
   return sum;
}