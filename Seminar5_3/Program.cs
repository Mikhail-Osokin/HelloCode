/*
Задача 33: Напишите программу, которая определяет присутствует ли заданное число в массиве
Например: 5 [4, -5, 0, 6, 5, -17] - да
          3 [4, -5, 0, 6, 5, -17] - нет
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

int [] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-3,5);
    }
    return result;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FindNumberInArray(int [] array, int nmb)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == nmb) 
        {
            Console.WriteLine("да");
            return;
        }
    }
    Console.WriteLine("нет");
}

int number = GetNumber("Введите число: ");
int [] arr = InitArray();
PrintArray(arr);
FindNumberInArray(arr, number);
