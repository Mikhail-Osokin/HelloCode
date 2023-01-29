Console.WriteLine("Введите число");
string? numberStr = Console.ReadLine();
if (numberStr != null)
{
    int number = Math.Abs(int.Parse(numberStr));
Console.WriteLine(number%10);
}