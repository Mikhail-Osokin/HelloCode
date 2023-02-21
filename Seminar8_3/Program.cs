/*
Задайте двумерный массив. Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен маименьший элемент массива

Например: 

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

9 2 3
4 2 4
2 6 7

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

(int,int) FindIndexesofMinMatrix(int [,] matrix)
{
    int min = matrix[0,0];
    int iMin = 0;
    int jMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < min)
            {
                min = matrix[i,j];
                iMin = i;
                jMin = j;
            }
        }
    }
    return (iMin,jMin);
}

int [,] DeleteMinRowsColumnsMatrix(int [,] matrix, int iMin, int jMin)
{
    int [,] replace = new int [matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    int countI = 0;
    int countJ = 0;
   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == iMin)
        {
            continue;
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != jMin)
            {
                replace[countI,countJ] = matrix[i,j];
                countJ++;
            }
        }
    countJ=0;
    countI++;
    }
return replace;
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
(int iMin, int jMin) = FindIndexesofMinMatrix(matrix);
int [,] newmatrix = DeleteMinRowsColumnsMatrix(matrix,iMin,jMin);
Console.WriteLine();
PrintMatrix(newmatrix);

