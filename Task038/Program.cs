// Задача 38:
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] NewArrayRndDouble(int size, int min, int max)
{
var array = new double[size];
var rnd = new Random();
for (int i = 0; i < size; i++)
{
double rndNum = rnd.NextDouble() * (max - min) + min;
array[i] = Math.Round(rndNum, 2);
}
return array;
}

void PrintArrayDouble (double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
if(i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
Console.WriteLine("]");
}

// double FindMaxElem(double[] list)
// {
//     double max = default;
//     for (int i = 0; i < list.Length; i++)
//     {
//         if (list[i]>max) max = list[i];
//     }
    
// return max;
// }

// double FindMinElem(double[] list)
// {
//     double min = default;  
//     for (int i = 0; i < list.Length; i++)
//     {
//         if (list[i]<min) min = list[i];
//     }
// return min;
// }
// double maxD = FindMaxElem(arr1);
// double minD = FindMinElem(arr1);
// double diffNum = maxD - minD;
// Console.WriteLine($"{maxD} {minD}");
// Console.WriteLine($"{diffNum}");

double DiffNum (double[] list)
{
   double max = default; 
   double min = default;

   for (int i = 0; i < list.Length; i++)
    {
        if (list[i]>max) max = list[i];
    }
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i]<min) min = list[i];
    }
double diff = max - min;
return diff;
}

double[] arr1 = NewArrayRndDouble(20, -25, 25);
PrintArrayDouble(arr1);
double diffNum = DiffNum (arr1);

Console.WriteLine($"Разница между минимальным и максимальным элементами массива = {diffNum}");