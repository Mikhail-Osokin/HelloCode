/* Задайте двумерный массив, найдите сумму элементов, находящихся на главной диагонали (у которых индексы равны)
Например:
1 2 3 4
1 2 3 4  = 10
1 2 3 4
1 2 3 4
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

int SumDiagonalElementsMatrix(int [,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j)
            {
                sum = sum + matrix[i,j];
            }
        }
    }
return sum;
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

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
int sum = SumDiagonalElementsMatrix(matrix);
Console.WriteLine($"Сумма элементов главной диагонали матрицы двумерного массива = {sum}");