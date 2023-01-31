/* Написать программу, которая на вход получает два числа и выводит является ли второе число кратным первому. 
Если второе число не кратно первому, то программа выдает остаток от деления

Например:
45 5 -> 45 кратно 5
3 2 -> остаток от деления 3 на 2 = 1
5 4 -> остаток от деления 5 на 4 = 1
*/

int GetNumbers(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberOne = GetNumbers("Введите первое число: ");
int numberTwo = GetNumbers("Введите второе число: ");
int result = numberOne % numberTwo;

if (result == 0)
{
    Console.WriteLine($"Число {numberTwo} кратно числу {numberOne}");
}
else
{
    Console.WriteLine($"Остаток отделения {numberOne} на {numberTwo} = {result}");
}
