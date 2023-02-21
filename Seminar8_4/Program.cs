/*
Составить частотный словарь элемнтов двумерного массива.
Частотный словарь содержит информацию о том сколько раз встречается элемент входных данных
{1, 9, 9, 0, 2, 8, 0, 9}
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
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

//Dictionary <int, int> dic =  new Dictionary<int, int>();

//dic.Add(1, 2)
//dic[1] = 45

Dictionary <int, int> GetDictionary(int [,] matrix)
{
    Dictionary <int, int> dic =  new Dictionary<int, int>();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (dic.ContainsKey(matrix[i,j]))
            {
                dic[matrix[i,j]]++;
            }
            else
            {
                dic.Add(matrix[i,j],1);
            }
        }
    }
return dic;
}

int [,] matrix = InitMatrix();
PrintMatrix(matrix);
Dictionary <int, int> dic = GetDictionary(matrix);

foreach (var item in dic.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key} встречается {item.Value} раз(а) ");
}