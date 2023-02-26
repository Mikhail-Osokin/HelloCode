/*
Задайте значения N и M. Напишите программу, 
которая выведет все наутарьные числа в промежутке от N до M.
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

string GetNeturalNumbers(int N, int M)
{
    if (M==N)
    {
        return N.ToString();
    }
    return N.ToString() + ", " + GetNeturalNumbers(N+1,M);
    
}

int N = GetNumber("Введите первое число: ");
int M = GetNumber("Введите первое число: ");
string result = GetNeturalNumbers(N, M);
Console.WriteLine(result);