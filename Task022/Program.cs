// Задача 22:
// Напишите программу, которая
// 1. принимает на вход число (N) и
// 2. выдает таблицу квадратов чисел от 1 до N.

// 2  4
// 3  9
// 4  16
// 5  25

// Console.WriteLine("Ведите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int counter = 1;

// while (counter <= number)
// {
//    Console.WriteLine($"{counter} -> {counter*counter}");
//     counter++;
// }

// метод

// Console.WriteLine("Ведите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= number)
// {
//     Console.WriteLine(Square(count));
//     count++;
// }
// string Square(int num)
// {
//     return ($"{num} -> {num * num}");
// }

// метод void

Console.WriteLine("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);
// вызов метода void

void Square (int num)
{
    int count = 1;
  while (count <= num)  
  {
    int square = count * count;
    Console.WriteLine($"|{count, 8} | {square, 8}|");
    // если после переменной через запятую поставить число, то значение будет выводиться в столбике с определенной шириной 
    count++;
  }
}