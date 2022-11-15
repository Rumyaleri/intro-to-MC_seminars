// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Введите количество строк матрицы: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбиков матрицы: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество слоев матрицы: ");
int z = Convert.ToInt32(Console.ReadLine());

int[] CreateUniqueElem(int x, int y,int z, int min, int max)
{
    int[] arr = new int[x*y*z];
    var rnd = new Random();
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
        temp = arr[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (arr[i] == arr[j])
                {
                    arr[i] = rnd.Next(min, max + 1);
                    j = 0;
                    temp = arr[i];
                }
                temp = arr[i];
            }
        }

    }
    // сортировка = проверка элементов массива на уникальность
    // for (int i = 0; i < arr.Length; i++)
    //         {
    //             for (int j = 0; j < i; j++)
    //             {
    //             if (arr[i] < arr[j])
    //             {
    //                 var t = arr[i];
    //                 arr[i] = arr[j];
    //                 arr[j] = t;
    //             }
    //         }
    //         }
    return arr;
}

int[,,] CreateMatrix3DInt(int x, int y,int z, int [] arr)
{

    int [,,] matr3D = new int [x, y, z];
    int a = 0;
    for (int i = 0; i < matr3D.GetLength(0); i++)
    {
        for (int j = 0; j < matr3D.GetLength(1); j++)
        {
            for (int k = 0; k < matr3D.GetLength(2); k++)
            {
                matr3D[i, j, k] = arr[a];
                a++;
            }
        }
    }
    return matr3D;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
                else Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine("");
    }
}

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }



int[] list = CreateUniqueElem(x, y,z, 10, 50);
// PrintArray(list);
int[,,] array3D = CreateMatrix3DInt(x, y, z, list);
PrintMatrix(array3D);