/*
Наишите программу, которая на вход принимает два числа
A и B и возводит число A в целую степень B
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

int Exponent(int numberA, int numberB)
{
    if (numberB == 1)
    {
        return numberA;
    }
    return numberA*Exponent(numberA,numberB-1);
}

int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число A: ");
Console.WriteLine();
Console.Write($"число {numberA}, возведенное в степень {numberB} = {Exponent(numberA,numberB)}");
