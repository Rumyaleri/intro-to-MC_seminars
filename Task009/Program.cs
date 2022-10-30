// задача 9 
//Напишите программу, которая
// 1. выводит случайное число из отрезка [10,99] и
// 2. показывает наибольшую цифру числа 


int number = new Random().Next(10, 100);
// в Random().Next указываем последнее значение диапазона на единицу больше, поэтому по условию задачи  - 10-99, а в оператор записываем 10-100
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if(firstDigit == secondDigit) Console.WriteLine($"Цифры одинаковые");
// else if(firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа  = {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа  = {secondDigit}");

// int res = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа  = {res}");  
// это встроенный метод Math.Max определения наибольшей цифры числа


//вызов метода: сначала переменная с маленькой буквы, потом метод с аргументом number
int maxDigit = MaxDigit(number); 
//имя метода каждое слово всегда с большой буквы - Paskal case
int MaxDigit(int num)
//в методе именование переменных должно отличаться от именования в программе, поэтому в программе number, а в методе num
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;
    // оператор return возвращает значение аргумента int и завершает работу метода, именно поэтому после if нет else, т.к. 
    // если первый return сработает, то ко второму программа уже не вернется

    //тернарный оператор = если первое число больше второго то (?) первое, иначе (:) второе
return firstDigit > secondDigit ? firstDigit : secondDigit;
// вместо 29 и 30 строки
}

Console.WriteLine($"Наибольшая цифра числа  = {maxDigit}");

