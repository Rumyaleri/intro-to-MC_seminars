Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.

void PrintRowsColumsIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }

    }
}
int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
if (array2D.GetLength(0) == array2D.GetLength(1))
{
    PrintMatrix(array2D);
    Console.WriteLine("");
    PrintRowsColumsIndex(array2D);
    PrintMatrix(array2D);
}
else Console.Write("невозможно");

Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.

int[] NewArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newArray[k] = matrix[i,j];
                k++;
            }
        }

    return newArray;
}

void CountElements(int[] array)
{
    int num = array[0]; //1
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++; //3
        else
        {
            Console.WriteLine($"{num} встречается {count} раз");
            num = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{num} встречается {count} раз");
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = NewArray(array2D);
Array.Sort(array);
PrintArray(array);

Console.WriteLine();
CountElements(array);



Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.

int[] FindMin(int[,] matrix)
{
    int min = matrix[0, 0];
    int minRow = 0;
    int minColumn = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return new int[] {min, minRow, minColumn};
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);

int[] min = FindMin(array2D);
PrintArray(min);



