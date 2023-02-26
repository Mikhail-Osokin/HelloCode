/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от 1 до N
Например:
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
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

string AllNaturalNumbers(int N)
{
    if (N == 1)
    {
        return "1";
    }
    return AllNaturalNumbers(N-1) + ", "+ N.ToString();
}

int N = GetNumber("Введите число: ");
string result = AllNaturalNumbers(N);
Console.WriteLine(result);