/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное
10->110
5->11
*/

int GetNumber(string message)

{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >0 )
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Повторите ввод");
        }
    }

    return result;
}

void NumberTranslation (int number)
{
    string result = string.Empty;
    while (number>0)
    {
        result = result + number%2;
        number = number/2;
    }
Console.WriteLine($"Двоичное представление введенного числа = {result}");
}

int number = GetNumber("Введите положительное число: ");
NumberTranslation(number);