// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и 
// 2. возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}

void FindMatrixElem(int[,] matr)
{
    Console.Write("Введите индекс строки: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбика: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i >= matr.GetLength(0) && i < 0 || j >= matr.GetLength(1) && j < 0)
        Console.WriteLine("Такого элемента в массиве нет");
    else if (i < 0 || j < 0)
        Console.WriteLine("Введено некорректное значение");
    else Console.WriteLine(matr[i, j]);
}

int[,] array2D = CreateMatrixRndInt(4, 10, -10, 10);
PrintMatrix(array2D);
FindMatrixElem(array2D);
