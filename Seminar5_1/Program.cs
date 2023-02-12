/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных эелементов массива.
Наример в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29, сумма отрицальных равна -20
*/

int [] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9,10);
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

int GetPositiveSum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) sum += array[i];
    }
    return sum;
}

int GetNegativeSum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) sum += array[i];
    }
    return sum;
}

Amounts GetAmounts(int [] array)
{
    Amounts item = new Amounts();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) 
            item.Negative += array[i];
        else
            item.Positive += array[i];        
    }
    return item;
}

(int, string, int) GetSumms(int [] array)
{
    int negative = 0;
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) 
            negative += array[i];
        else
            positive += array[i];        
    }
    return (negative, " ", positive);
}

int [] arr = InitArray();
PrintArray(arr);
int posSum = GetPositiveSum(arr);
int negSum = GetNegativeSum(arr);
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива = {posSum}, сумма отрицательных элементов массива = {negSum}");

Amounts item = GetAmounts(arr);
Console.WriteLine($"Сумма положительных элементов массива = {item.Positive}, сумма отрицательных элементов массива = {item.Negative}");

(int negative, string str, int positive) = GetSumms(arr);
Console.WriteLine($"Сумма положительных элементов массива = {positive}, сумма отрицательных элементов массива = {negative}");

class Amounts
{
    internal int Negative{get;set;}
    internal int Positive{get;set;}
}