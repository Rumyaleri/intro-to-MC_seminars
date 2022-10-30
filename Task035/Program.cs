// Задача 35.
// Напечатайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в диапазоне [10, 99]. Двузначные числа.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int RangeDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) count++;
    }
    return count;
}

// // метод который будет возвращать массив (в данной задаче состоящий из двух элементов - суммы отр. и суммы положительных)
// int[] GetSumPositiveNegativeElem(int[] array)
// {
//     int sumNegative = default;
//     int sumPositive = default;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] <0) sumNegative += array[i];
//         else sumPositive += array[i];
//     }
//     // int[] result = new int[sumNegative, sumPositive];
//     // int[] result = new int[2];
//     // result[0] =  sumNegative;
//     // result[1] = sumPositive;
//     return new int[] {sumNegative, sumPositive};
// }




int[] arr = CreateArrayRndInt(123, 0, 999);
PrintArray(arr);
// Console.Write("Введите минимальное число диапазона: "); // ввели проверочное число
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число диапазона: "); // ввели проверочное число
// int numberB = Convert.ToInt32(Console.ReadLine());
// int count = RangeDigits(arr, numberA, numberB);
int num = RangeDigits(arr);
Console.WriteLine($"Количесво элементов, которые лежат в диапазоне от 10 до 99 --> {num}");

// int[] result = GetSumPositiveNegativeElem(arr);
// Console.WriteLine($"Сумма положительных чисел {result [1]}");
// Console.WriteLine($"Сумма отрицательных чисел {result [0]}");