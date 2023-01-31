/* Напишите программу, которая принимает на вход два числа, проверяет является ли одно число квадратом другого

Например:
25 5 -> 25 является квадратом числа 5
4 15 -> 15 не является квадратом числа 4
*/

int GetNumbers(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberOne = GetNumbers("Введите первое число: ");
int numberTwo = GetNumbers("Введите второе число: ");
if (numberOne>numberTwo)    // if (numberTwo*numberTwo==numberOne||numberOne*numberOne==numberTwo)
{
    if (numberTwo*numberTwo==numberOne)
    {
        Console.WriteLine($"Число {numberOne} является квадратом числа {numberTwo}");
    }
    else
    {
        Console.WriteLine($"Число {numberOne} не является квадратом числа {numberTwo}");
    }
}
if (numberOne<numberTwo)
{
    if (numberOne*numberOne==numberTwo)
    {
        Console.WriteLine($"Число {numberTwo} является квадратом числа {numberOne}");
    }
    else
    {
        Console.WriteLine($"Число {numberTwo} не является квадратом числа {numberOne}");
    }
}