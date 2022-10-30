

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int DecToBin(int number)
{
    // int result = 0;
    // while (number > 0)
    // {
    //     result = (number % 2) + (result * 10);
    //     number = number / 2;
    // }
    // return result;
    int temp = 0;
    int count = 1;
    while (number > 0)
    {
        temp = temp + number % 2 * count;
        number = number / 2;
        count = count * 10;

    }
    return temp;
}

int decToBin = DecToBin(num);
Console.WriteLine(decToBin);