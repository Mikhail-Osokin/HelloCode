/*
Ввести массив через консоль
*/

Console.WriteLine("Введите числа через пробел");
string [] strArray = Console.ReadLine().Split(' ');
int [] result = new int[strArray.Length];
for (int i = 0; i < result.Length; i++)
{
    result[i]=int.Parse(strArray[i]);
}
Console.WriteLine(string.Join(',', result));