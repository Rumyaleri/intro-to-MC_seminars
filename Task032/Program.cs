// Задача 32.
// Напишите программу замены элементов массива:
// положительные элементы заменить на соответствующие отрицательные и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, 2]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int [size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
} 

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


void ViseVersa(int[] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}


int[] arr = CreateArrayRndInt(20, -15, 15);
PrintArray(arr);
ViseVersa(arr);
PrintArray(arr);


