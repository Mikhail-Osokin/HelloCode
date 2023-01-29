Console.WriteLine("Введите число от одного до семи!");
int number = Convert.ToInt32(Console.ReadLine());
if (number==1)
{
    Console.WriteLine("Сегодня понедельник");
}
if (number==2)
{
    Console.WriteLine("Сегодня вторник");
}
if (number==3)
{
    Console.WriteLine("Сегодня среда");
}
if (number==4)
{
    Console.WriteLine("Сегодня четверг");
}
if (number==5)
{
    Console.WriteLine("Сегодня пятница");
}
if (number==6)
{
    Console.WriteLine("Сегодня суббота");
}
if (number==7)
{
    Console.WriteLine("Сегодня воскресенье");
}
else
{
    Console.WriteLine("Вы ввели число не от одного до семи");
}


