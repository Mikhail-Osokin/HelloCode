Console.WriteLine("Введите число A!");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B!");
int B = Convert.ToInt32(Console.ReadLine());
if (A/B == B)
{
    Console.WriteLine($"Число {A} является квадртом числа {B}");
}
else
{
    Console.WriteLine($"Число {A} не является квадртом числа {B}");
}