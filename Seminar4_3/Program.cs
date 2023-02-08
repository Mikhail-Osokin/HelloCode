/*
Напишите программу, которая принимает на вход число (N) и выдает произведение чисел от 1 до N
4 -> 24
5 -> 120
2 -> 2
*/

int GetNumber(string message)

{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >=1)
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

double GetMult(int number)
{
    double mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult=mult*i;
    }
    return mult;
}

int number = GetNumber("Введите любое число больше единицы:");
double result = GetMult(number);
Console.WriteLine($"Факториал числа {number} = {result}");
