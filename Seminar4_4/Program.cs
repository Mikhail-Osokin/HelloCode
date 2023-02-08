/*
Написать программу, которая выдает массив из 8 элементов, заполненный нулями и единицами в случайном порядке
[1,0,1,0,0,1,1,0]
*/

int [] array = new int[8];
void InitArray(int [] array)
{
    int i = 0;
    Random rnd = new Random();
    while (i<array.Length)
    {
        array[i] = rnd.Next(0,2);
        i++;
    }
}

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

InitArray(array);
PrintArray(array);
