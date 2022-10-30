// Задача 49: 
// 1. Задайте двумерный массив. 
// 2. Найдите элементы, у которых оба индекса чётные, и 
// 3. замените эти элементы на их квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// void EvenElemGetSquare(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) matr[i, j] *= matr[i, j];
//         }
//     }
// }

void EvenElemGetSquare(int[,] matr) // если в счетчике поставить +2, то не нужно проверка If (i % 2 == 0 && j % 2 == 0)
{
    for (int i = 0; i < matr.GetLength(0); i+=2)
    {
        for (int j = 0; j < matr.GetLength(1); j+=2)
        {
            matr[i, j] *= matr[i, j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}


int[,] arr2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(arr2D);
Console.WriteLine();
EvenElemGetSquare(arr2D);
PrintMatrix(arr2D);