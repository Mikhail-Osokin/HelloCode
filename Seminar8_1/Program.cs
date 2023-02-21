/*
Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива
Например:

1 2 3 4      4 5 6 7
5 6 7 9  ->  5 6 7 9
4 5 6 7      1 2 3 4 
*/

int [,] InitMatrix()
{
    int [,] matrix = new int [4,4];
    Random rmd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rmd.Next(1,10); 
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

void ReplaceFirstLastRowsMatrix(int [,] matrix)
{
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j] = temp;
    }
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
ReplaceFirstLastRowsMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);