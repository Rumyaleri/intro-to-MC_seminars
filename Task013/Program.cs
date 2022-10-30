Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number >= 999)
    {
        number = number / 10;
    }
    int findDigit = number % 10;
    Console.WriteLine($"Третья цифра числа: {findDigit}");
}
else
    Console.WriteLine($"Третья цифра отсутствует");


// это метод с проверкой на количество знаков, если больше то введено некорректное число
int number = 23534;
if (Check (number))
{
    int res Method (number)
}

bool Check(int num)
{
    return number >= 100 && number <= 999;
}


int Method(int num)
{
    return num / 10 % 10;
}