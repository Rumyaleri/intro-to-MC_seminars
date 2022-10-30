// Задача 46: 
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
//   1      4     8     19   i(0)
//   5     -2    33     -2   i(1)
//   77     3     8      1   i(2)
//  j(0)  j(1)  j(2)   j(3)

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
    //в двумерном массиве вводим размерность : int rows - кол-во строк, int columns - кол-во столбцов
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //перешли на новую строку.
    // for (int i = 0; i < 3; i++) для 3 строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //прошлись в выбраной строке по всем столбцам
        // for (int j = 0; j < 4; j++) для 4 столбцов
        {
            matrix[i,j] = rnd.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
            // {matrix[i,j], 4} 4 - это форматирование, чтобы строки и столбцы были ровные
        else Console.Write($"{matrix[i,j], 4}");
        }
           Console.WriteLine("|");
    }
}


int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);

