// Задача 15: 
// Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите порядковый номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    Weekend();    
}
else
    Console.WriteLine("введен некорректный номер");

bool Weekend(int num)
    {
        return num > 5 && num < 8;
    }

    if (Weekend(day))
        Console.WriteLine("Это выходной день");
    else
        Console.WriteLine("это не выходной день");