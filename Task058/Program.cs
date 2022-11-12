// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбиков первой матрицы: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбиков второй матрицы: ");
int y2 = Convert.ToInt32(Console.ReadLine());

if (x1 != y2) //&& x1 <= 0 && y1 <= 0 && x2 <= 0 && y2 <= 0
{
    Console.Write("Заданы некорректные параметры. Умножение невозможно");
    return;
}

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}|");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
}
int[,] MatrixMultiply(int[,] matr1, int[,] matr2)
{

    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    {
        for (int i = 0; i < matr3.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                matr3[i, j] = 0;
                for (int n = 0; n < matr1.GetLength(1); n++)
                {
                    matr3[i, j] += matr1[i, n] * matr2[n, j];
                }
            }
        }
    }
    return matr3;
}

int[,] array2D = CreateMatrixRndInt(x1, y1, 1, 5);
PrintMatrix(array2D);
Console.WriteLine();
int[,] matrix2D = CreateMatrixRndInt(x2, y2, 1, 5);
PrintMatrix(matrix2D);
Console.WriteLine();
int[,] matrixMultiply = MatrixMultiply(array2D, matrix2D);
PrintMatrix(matrixMultiply);


