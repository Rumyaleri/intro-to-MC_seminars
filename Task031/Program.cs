// Задача 31.
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из диапазона [-9, 9].
// 3. Найдите сумму положительных и отрицательных элементов массива.
// 4. Вывод результата.

// Например в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных чисел равна -20.

// метод создания массива известного размера
int[] CreateArrayRndInt(int size, int min, int max)
// метод создания массива. Входящие аргументы - размер массива, минимальный элемент и максимальный элемент - диапазон
{
    int[] array = new int [size];
    // создали массив заполненный нулями. вместо int[] можно использовать var
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
        // проходим по всему массиву и присваиваем нужные значения
    }
    return array;
} 

// метод печати массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

// метод который будет возвращать массив (в данной задаче состоящий из двух элементов - суммы отр. и суммы положительных)
int[] GetSumPositiveNegativeElem(int[] array)
{
    int sumNegative = default;
    int sumPositive = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <0) sumNegative += array[i];
        else sumPositive += array[i];
    }
    // int[] result = new int[sumNegative, sumPositive];
    // int[] result = new int[2];
    // result[0] =  sumNegative;
    // result[1] = sumPositive;
    return new int[] {sumNegative, sumPositive};
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);


int[] result = GetSumPositiveNegativeElem(arr);
Console.WriteLine($"Сумма положительных чисел {result [1]}");
Console.WriteLine($"Сумма отрицательных чисел {result [0]}");
