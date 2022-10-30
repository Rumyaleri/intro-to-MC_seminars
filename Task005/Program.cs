// 5. Напишите программу, которая 
// 1. на вход принимает одно число (N), а 
// 2. на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// через цикл

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"все целые числа в промежутке от -{number} до {number} ");

int counter = -number;
// начало счетчика начинается от минимального значения переменной -n
while(counter <= number)
{
    Console.Write($"{counter} ");
    counter++;
}