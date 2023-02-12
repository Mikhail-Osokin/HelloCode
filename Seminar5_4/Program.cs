/*
Задача 34: Задайте одномерный массив из 123 случайных чисел, найдите значения элементов массива,
значения которых лежат в отрезке [10, 99]
*/

int [] InitArray()
{
    int[] result = new int[50];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-200,500);
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

void PrintNumbersOfArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<=99 && array[i] >= 10) Console.Write($"{array[i]} ");
    }
}

int CountNumbersOfArray(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<=99 && array[i] >= 10) 
            count++;
    }
return count;
}

int [] arr = InitArray();
PrintArray(arr);
Console.WriteLine();
PrintNumbersOfArray(arr);
int count = CountNumbersOfArray(arr);
Console.WriteLine();
Console.WriteLine($"Количество элементов, входящих в диапазон от 10 до 99 = {count}");