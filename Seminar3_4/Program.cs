/* Напишите программу, которая по заданному номеру чсетвери показывает диаппзон возможных координат, точку этой четверти (x,y) */

int GetNumber (string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result <5 && result >0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не номер четверти или 0. Повторите ввод");
        }
    }

    return result;
}

void GetQuarter (int x)
{
    if (x == 1)
        Console.WriteLine("Значения х >0 и y>0");
    else if (x == 2)
        Console.WriteLine("Значения х <0 и y>0");
    else if (x == 3)  
        Console.WriteLine("Значения х <0 и y>0");
    else 
        Console.WriteLine("Значения х >0 и y<0");
}

int x = GetNumber("Введите номер четверти от 1 до 4");
GetQuarter(x);