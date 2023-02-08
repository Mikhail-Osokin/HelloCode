/*
Напишите программу, которая принимет на вход число (А) и выдает сумму от 1 до А
7 -> 28
4 -> 10
8 -> 36
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

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <=number; i++)
    {
        sum+= i; // sum = sum + i
    }
    return sum;
}

int number = GetNumber("Введите число больше 0:");
int sum = GetSum(number);
Console.WriteLine($"Сумма числе от 1 до {number} = {sum}");