/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле A[m,n] = m+n. Выведите полученный массив на экран.
Наример: m = 3, n = 4
0 1 2 3
1 2 3 4
2 3 4 5
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

/*int [,] InitMatrix()
{
    int [,] matrix = new int [3,4];
    Random rmd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //for (int z = 0; z < matrix.GetLength(2); z++)
            {
                
            }//
            matrix[i,j] = rmd.Next(1,10); // matrix[i,j] = GetNumber();
        }
    }
return matrix;
}
*/

int [,] InitMatrix()
{
    int [,] matrix = new int [3,4];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i+j;
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

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
