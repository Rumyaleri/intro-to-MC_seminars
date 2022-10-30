// Задача 30: Напишите программу, которая
// 1. выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// 12


int[] FillArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 30);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}", string.Join(", ", arr));
    }
}

int[] myArr = FillArray(8);
PrintArray(myArr);
