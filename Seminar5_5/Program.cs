/*
Найдите произведение пар чисел в одномерном массиве. Парой считается первый и последний элемент, второй и предпоследний итд. Результат записать в новом массиве.
Наример: [1,2,3,4,5] -> 5 8 3
[6, 7, 3, 6] -> 36 21
*/

int [] InitArray()
{
    int[] result = new int[11];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1,10);
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

int [] MultiElements(int [] array)
{
    int [] multiArr;
    if (array.Length%2 == 0)
        multiArr = new int [array.Length/2];
    else
        multiArr = new int [array.Length/2+1];
    for (int i = 0; i < array.Length/2; i++)
    {
        multiArr[i] = array[i]*array[array.Length-i-1];
    }
    if (array.Length%2 != 0)
        multiArr[multiArr.Length-1]=array[array.Length/2];
    return multiArr;
}

int []arr = InitArray();
PrintArray(arr);
Console.WriteLine();
int []arr1 = MultiElements(arr);
PrintArray(arr1);