/*
Напишите программу, которая будет принимать на вход число
возвращать сумму его цифр
Например:
453 -> 12
45 -> 9
*/

int GetNumber(string message)

{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result>=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число. Повторите ввод");
        }
    }

    return result;
}

int GetSumDigitsOfNumber(int number, int sum)
{
    if (number == 0)
    {
        return sum;
    }
    else 
    sum += number%10;
    number /= 10;
    return GetSumDigitsOfNumber(number, sum);
}

int number = GetNumber("Введите число: ");
int sum = 0;
int result = GetSumDigitsOfNumber(number,sum);
Console.Write(result);