/* Напишите программу, которая принимает на вход три числа и проверяет 
может ли существовать треугольник со сторонами такой длинны 
(Теорема о неравенстве сторон треугольника: Сторона треугольника меньше суммы двух других сторон)
*/

int GetNumber(string message)

{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
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

void CheckForTriangle(int a, int b, int c)
{
    if (a<b+c && b<a+c && c<a+b)
        Console.WriteLine($"стороны с длинами {a}, {b}, {c} образуют треугольник");
    else
        Console.WriteLine($"стороны с длинами {a}, {b}, {c} не образуют треугольник");
}

int a = GetNumber("Введите число а: ");
int b = GetNumber("Введите число b: ");
int c = GetNumber("Введите число c: ");

CheckForTriangle(a,b,c);