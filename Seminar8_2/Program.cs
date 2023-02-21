/*
Задайте двумерный массив. Напишите программу, которая меняет местами строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя

1 2 3   _   1 2
2 3 4       2 3
            3 4

1 2 3      1 1 1
1 2 3  ->  2 2 2
1 2 3      3 3 3

*/

int [,] InitMatrix()
{
    int [,] matrix = new int [4,5];
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

int [,] ReplaceRowsColumnsMatrix(int [,] matrix)
{
    int [,] replace = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            replace[i,j] = matrix[j,i];
        }
    }
return replace;
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
int [,] newmatrix = ReplaceRowsColumnsMatrix(matrix);
Console.WriteLine();
PrintMatrix(newmatrix);