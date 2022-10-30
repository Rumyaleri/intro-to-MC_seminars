// Задача 41: 
// Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3проверяться: 


Console.Write("Введите количество чисел для проверки: ");
int n = Convert.ToInt32(Console.ReadLine());
int number = default;
if (n < 0)
{
    Console.Write("Введено некорректное число");
    return;
}
else number = n;

int[] CreateUsersArray(int num)
{
    int[] myArray = new int[num];
    int serialNum = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите число №{serialNum}: ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
        serialNum++;
    }
    return myArray;
}

int PositiveElemCount(int[] list)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] > 0) count++;
    }
    return count;
}

int[] arr = CreateUsersArray(number);
int positiveElemCount = PositiveElemCount(arr);
Console.Write($"Количество чисел больше 0 = {positiveElemCount}");
