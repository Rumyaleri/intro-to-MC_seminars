//Задача 52.
//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

// double ColumnsAverage(int[,] matr)
// {
//        double sum = 0;
//        double avgSum = 0;
//         for (int i = 0; i < matr.GetLength(0); i++)
//         {

//             int j=0;
//                 sum += matr[i, j];
//                 avgSum = Math.Round((sum / matr.GetLength(0)), 1);
//             }
//             return avgSum;
// }

double[] ColumnsAverage(int[,] matr)
{
    // double avgSum = 0;
    int size = matr.GetLength(1);
    var newArrayDouble = new double[size];
    // for (int n = 0; n < size; n++)
    // {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            double sum = 0;
            double avgSum = 0;
            for (int n = 0; n < size; n++)
            {
            for (int i = 0; i < matr.GetLength(0); i++)
            {                
                sum += matr[i, j];
                avgSum = sum / matr.GetLength(0);
            }  
             newArrayDouble[n] = avgSum;
            } 
        } 
    //  } 
            return newArrayDouble;
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
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int n = 0; n < array.Length; n++)
    {
        if (n < array.Length - 1) Console.Write($"{array[n]}, ");
        else Console.Write($"{array[n]}");
    }
    Console.WriteLine("]");
}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
double[] array1D = ColumnsAverage(array2D);
// double avgSum = ColumnsAverage(array2D);
// Console.WriteLine(avgSum);
PrintArray(array1D);