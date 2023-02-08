/* 
напишите программу, которая принимает на вход число и выдает количество цифр в числе
456 -> 3
78 -> 2
89126 ->5
*/

int GetNumber(string message)

{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
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

int GetCountOfDigits(int number)
{
    int count = 0;
    while (number != 0)
    {
        number = number/10;
        count++;
    }
    return count;
}

int number = GetNumber("Введите число");
int count = GetCountOfDigits(number);
Console.WriteLine($"Количество цифр в числе {number} = {count}");