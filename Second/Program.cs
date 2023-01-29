/* напишите программу, которая на воход принимает число 
и вывает его квадрат (число, умноженое само на себя)

Наример:
4 -> 16
3 -> 9
-7 -> 49
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine() ?? ""; //12243324 апывываваа 3553445345
int number = Convert.ToInt32(numberStr);
int result = number*number;
Console.WriteLine($"Квадрат числа {number} равен {result}");


