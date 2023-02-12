/*
Задача 32: Напишите программу замены элементов массива: положительные элементы заменяются на соответствующие отрицательные и наоборот
Например: [4, 8, -8, -2] -> [-4, -8, 8, 2]
*/

int [] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-999,1000);
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

void ReplacePosNeg(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*(-1);
    }
}

int [] arr = InitArray();
PrintArray(arr);
Console.WriteLine();
ReplacePosNeg(arr);
PrintArray(arr);