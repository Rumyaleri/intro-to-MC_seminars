// Задача 51: 
// 1. Задайте двумерный массив. 
// 2. Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами(0,0); (1;1) и т.д.


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

// int MainDiagonalSum(int[,] matr)
// {
//     int sum = 0;
//     {
//         for (int i = 0; i < matr.GetLength(0); i++)
//         {
//             for (int j = 0; j < matr.GetLength(1); j++)
//             {
//                 if (i == j) sum += matr[i, j];
//             }
//         }
//     }
//     return sum;
// }

int MainDiagonalSum(int[,] matr) // метод с 1 циклом должен работать с измерением которое меньше, 
                                    //если меньше строк то по строкам, если столбцов - то со столбцами
{
    int sum = 0;
    int dimention = 0; //эта переменная задается для того, чтобы присваивать ей значение меньшего измерения (либо строк либо столбцов) 
    if (matr.GetLength(0) > matr.GetLength(1)) dimention = 1;  // присвоение меньшего значения измерения, чтбы не было выхода за пределы массива
    {
        for (int i = 0; i < matr.GetLength(dimention); i++)
        {
                if (i == i) sum += matr[i, i];
        }
    }
    return sum;
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


int[,] array2D = CreateMatrixRndInt(3, 5, 1, 100);
PrintMatrix(array2D);
int mainDiagonalSum = MainDiagonalSum(array2D);
Console.WriteLine($"Сумма элементов главной диагонали равна {mainDiagonalSum}");