// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] NewArrayRndInt(int size, int min, int max)
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
    Console.Write("]");
}

int OddIndexElemSum(int[] list)
{
    int sum = default;
    for (int i = 0; i < list.Length; i++)
    {
        if (i % 2 == 1) sum = sum + list[i];
    }
    return sum;
}

int[] arr = NewArrayRndInt(10, -50, 50);
PrintArray(arr);

int sumElem = OddIndexElemSum(arr);
Console.WriteLine($"--> {sumElem}");