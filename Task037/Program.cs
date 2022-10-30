// задача 37.
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат записать в новом массиве.


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     var rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

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

// int[] NewArray(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1) size = size + 1;
//     int[] newArr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArr[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 == 1) newArr[size - 1] = array[size - 1];
//     return newArr;
// }

// int[] arr = CreateArrayRndInt(5, 0, 10);
// PrintArray(arr);

// int[] newArray = NewArray(arr);
// PrintArray(newArray);

// int[] CreateArrayRndInt(int size, int min, int max)
// {
// int[] array = new int[size];
// var rnd = new Random();
// for (int i = 0; i < size; i++)
// {
// array[i] = rnd.Next(min, max + 1);
// }
// return array;
// }

// void PrintArray(int[] array)
// {
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
// if(i < array.Length - 1) Console.Write($"{array[i]}, ");
// else Console.Write($"{array[i]}");
// }
// Console.WriteLine("]");
// }

// int[] NewArray(int[] array)
// {
// int size = array.Length / 2;
// if (array.Length % 2 == 1) size = size + 1;
// int[] newArr = new int[size];

// for (int i = 0; i < size; i++)
// // проходимся до середины массива, поэтому i < size
// {
// newArr[i] = array[i] * array[array.Length - 1 - i];
// }
// if (array.Length % 2 == 1) newArr[size-1] = array[size-1];
// // чтобы оставить число которое в середине неизменным  - newArr[size-1] = array[size-1];
// return newArr;
// }

// int[] arr = CreateArrayRndInt(8, 0, 10);
// PrintArray(arr);

// int[] newArray = NewArray(arr);
// PrintArray(newArray);


// // массив вещественных чисел
// double[] CreateArrayRndDouble(int size, int min, int max)
// {
// double[] array = new double[size];
// var rnd = new Random();
// for (int i = 0; i < size; i++)
// {
// double rndNum = rnd.NextDouble()* (max - min) - min; //создаем переменную - это каждый элемент в массиве
// // next создает массив с целочисленными цифрами, для doule  используется NextDouble(). Он не принимает никаких параметров, 
// //поэтому добавляем множитель (max - min) - min 
// array[i] = Math.Round(rndNum, 2); // все элементы в массиве получают 2 знака после запятой
// }
// return array;
// }

// void PrintArrayDouble(double[] array)
// {
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
// if(i < array.Length - 1) Console.Write($"{array[i]}, ");
// else Console.Write($"{array[i]}");
// }
// Console.WriteLine("]");
// }

double[] arr1 = CreateArrayRndDouble(12, -9, 9);
PrintArrayDouble(arr1);

double[] CreateArrayRndDouble(int size, int min, int max)
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