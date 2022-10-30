// Задача 33.
// Задайте массив.
// Напишите программу, которая определяет присутствует ли заданное число в массиве.

// int[] CreateArrayRndInt(int size, int min, int max)
// // метод создания массива. Входящие аргументы - размер массива, минимальный элемент и максимальный элемент - диапазон
// {
//     int[] array = new int [size];
//     // создали массив заполненный нулями. вместо int[] можно использовать var
//     var rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max+1);
//         // проходим по всему массиву и присваиваем нужные значения
//     }
//     return array;
// } 

// метод печати массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

//вариант1
// bool FindTheSameDigit(int[] array, int num)
// {
//     bool result = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (array[i] == num)
//        {
//         result = true;
//         break;
//        } 
//     }
//     return result;
// }

//вариант 2
bool FindTheSameDigit(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] == num) return true;
    }
    return false;
}

int[] array = {6, 7, 19, 345, 3}; // задали массив
Console.Write("Введите число: "); // ввели проверочное число
int number = Convert.ToInt32(Console.ReadLine()); 
PrintArray(array); // напечатали массив
//вывод варианта 1
// if (FindTheSameDigit (array, number)) Console.WriteLine("yes"); // совпало - да
// else Console.WriteLine("No"); // не совпало - нет


//вывод варианта 2
bool find = FindTheSameDigit (array, number);
// if (find) Console.WriteLine("yes");
// else Console.WriteLine("No");

Console.WriteLine(find ? "yes" : "no"); //тернарный оператор вместо 68 и 69 строки