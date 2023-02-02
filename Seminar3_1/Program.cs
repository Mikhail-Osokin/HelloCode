/*
Напишите программу, которая принимает на вход координаты точки (X и Y), причем X#0 и Y#0
и выдает номер четверти плоссокти, в которой находится эта точка
       Y     
  2    |     1
       |   
----------------X
       |
  3    |     4
       |   

1. получить x и y с консоли
2. получить номер четверти, где лежит точка с координатами (x,y)
3. вывести результат на экран
*/

int GetNumber (string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result !=0)
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

/* 
1. reference types (ссылочные типы)
 - class, array, list, char
 - хранятся в управляемой куче
 - работаем с их ссылками

2. value types (значимые типы)
 - int, double, float, decimal, long, bit, byte, struct, enum, datetime
 - хранятся в стеке (оперативная память компьютера/сервера/выделенная память в облаке)
 - работаем с их значением
 */

 void Temp (int x)
 {
    x = x*10;
 }

int number = 5;
Temp(number);
Console.WriteLine(number); // 5

void Temp1 (int [] arr)
{
    Random rmd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rmd.Next(1, 10);
    }
}

int [] array = new int[8];
//Console.Write(string.Join(",", array));

Temp1(array);

Console.Write(string.Join(",", array)); //

int GetQuarter (int x, int y)
{
    if (x>0 && y>0)
        return 1;
    else if (x<0 && y>0)
        return 2;
    else if (x<0 && y<0)
        return 3;
    else 
        return 4;
}

int x = GetNumber("Введите X отличный от нуля:");
int y = GetNumber("Введите Y отличный от нуля:");

int quarter = GetQuarter(x,y);
Console.WriteLine($"Точка с координатами ({x},{y}) лежит в {quarter} четверти");



