/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа ФибоначчиЖ 0 и 1
Например: Если N = 5 -> 0 1 1 2 3
          Если N = 3 -> 0 1 1
          Если N = 7 -> 0 1 1 2 3 5 8
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

void Fibonacci(int number)
{
    int fib1 = 0;
    int fib2 = 1;
    int sum = 0;

    if (number == 1)
    {
        fib2 = 0;
        Console.WriteLine(fib2);
    }
    else 
    {
        fib2 = 1;
        Console.Write("0 1 ");    
        for (int i = 0; i < number -2; i++)
        {
            sum = sum + fib2;
            fib1 = fib2;
            fib2 = sum;
            Console.Write($"{sum} ");
        }
    }
}

int number = GetNumber("Введите положительное число: ");
Fibonacci(number);
