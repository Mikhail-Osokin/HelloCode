/* Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

Например:
78->8
12->2
85->8

1. получить рандомное число в диапазоне [10, 99]
2. получить максимальную цифру числа

*/

int GetNumber()
{
    Random rmd = new Random();
    int result = rmd.Next(10, 100); // [left, right)
    return result;
}

int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit) 
        return firstDigit;
    else 
        return secondDigit;
}

int number = GetNumber();
int maxDigit = GetMaxDigitOfNumber(number);

Console.WriteLine($"максимальное цифра числа {number} = {maxDigit}");