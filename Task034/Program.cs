// Задача 34:
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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

int EvenNumCount(int[] list)
{
    int count = default;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] % 2 == 0) count++;
    }
    return count;
}

int[] arr = NewArrayRndInt(25, 100, 999);
PrintArray(arr);

int num = EvenNumCount(arr);
Console.WriteLine($"--> {num}");

