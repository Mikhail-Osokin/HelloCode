/*
Задайте двумерный массив размера m на n, найдите элементы у которых оба индекса четные, замените эти элементы на их квадрат.
Например изначально массив



*/

int GetNumber()
{
    int result;
    while (true)
    {
        Console.WriteLine("Введите число");

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число");
        }
    }
    return result;
}

int [,] InitMatrix()
{
    int [,] matrix = new int [4,4];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = GetNumber();
        }
    }
return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}

void ChangeEvenElementsMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (i%2 != 0 && j%2 != 0)
           {
                matrix[i,j] = matrix[i,j]*matrix[i,j];
           } 
        }
    }
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
ChangeEvenElementsMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);