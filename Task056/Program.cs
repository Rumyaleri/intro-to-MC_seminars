// Задача 56: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();
    for (int n = 0; n < matrix.GetLength(0); n++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[n, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[] SunOfRowElem(int[,] matr)
{
    int k = 0;
    int[] array = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        array[k] = sum;
        k++;
    }
    return array;
}

void MinElemIndex(int[] list)
{
    int min = list[0];
    int minRow = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] < min)
        min = list[i];
    }
    for (int i = 0; i < list.Length; i++)
    {
        if (min == list[i]) minRow = i+1; 
    }
    Console.WriteLine($"Строка под номером {minRow} содержит минимальную сумму элементов");
}

void PrintMatrix(int[,] matrix)
{
    for (int n = 0; n < matrix.GetLength(0); n++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[n, j],4}, ");
            else Console.Write($"{matrix[n, j],4}");
        }
        Console.WriteLine("|");
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int n = 0; n < array.Length; n++)
    {
        if (n < array.Length - 1) Console.Write($"{array[n],4}, ");
        else Console.Write($"{array[n],4}");
    }
    Console.WriteLine("]");
}


int[,] array2D = CreateMatrixRndInt(5, 10, 1, 10);
PrintMatrix(array2D);

int[] array1D = SunOfRowElem(array2D);
PrintArray(array1D);
MinElemIndex(array1D);