/* 
Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного копирования
*/

int [] InitArray ()
{
    int [] result = new int [6];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 10);
    }
return result;
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int [] CopyArray(int [] array)
{
    int [] result = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i]=array[i];
    }
    return result;
}

int [] arr = InitArray();
PrintArray(arr);
int [] result = CopyArray(arr);
PrintArray(result);