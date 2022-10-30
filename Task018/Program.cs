// Задача 18.
// Напишите программу, которая
// 1. принимает номер четверти
// 2. выдает диапазон возможных координат точек в этой четверти (X и Y).

Console.WriteLine("Ведите номер четверти координатной плоскости: ");
string number = Console.ReadLine();
string result = Range(number);

Console.WriteLine(result);

string Range (string num)
{
    if (num == "1") return "В четверти 1 координаты X > 0 и Y > 0";
    if (num == "2") return "В четверти 2 координаты X < 0 и Y > 0";
    if (num == "3") return "В четверти 3 координаты X < 0 и Y < 0";
    if (num == "4") return "В четверти 4 координаты X > 0 и Y < 0";
    return "Некорректный ввод";
}

// можно попробовать через swich