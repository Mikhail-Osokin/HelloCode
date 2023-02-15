/*
Напишите программу, которая перевертнет одномерный массив 
(последний элемент будет на первом месте, а послений - на первом)
Например: [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]
[6 7 3 6] -> [6 3 7 6]
*/

int [] InitArray (int dimension)
{
    int [] result = new int [dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
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

int [] ReverseArray(int [] array)
{
    int [] result = new int [array.Length];
    int count=0;

    for (int i = array.Length - 1 ; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }
    return result;
}

int [] arr = InitArray(10);
PrintArray(arr);
int [] result = ReverseArray(arr);
PrintArray(result);
Array.Reverse(result);
PrintArray(result);