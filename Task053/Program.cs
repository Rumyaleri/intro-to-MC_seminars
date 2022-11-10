// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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



void PrintRowsColumsIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }

}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine("");
PrintRowsColumsIndex(array2D);
PrintMatrix(array2);
