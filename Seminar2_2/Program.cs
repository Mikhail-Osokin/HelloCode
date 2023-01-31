/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

Например:
678->68
567->57
145->15
*/

int GetNumber()
{
    Random rmd = new Random();
    int result = rmd.Next(100, 1000); // [left, right)
    return result;
}

int DelSecondDigitOfNumber(int number)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    return (firstDigit*10+thirdDigit);
}

int number = GetNumber();
int result = DelSecondDigitOfNumber(number);

Console.WriteLine($"полученное число после удаления второй цифры числа {number} = {result}");
