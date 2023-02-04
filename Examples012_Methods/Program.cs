//Вид 1
void Method1()
{
    Console.WriteLine("Автор...");
}

Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2 ("Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}

Method2_1(msg: "Текст", count: 4);
Method2_1(count: 4, msg: "Новый текст");


// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 4

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i<count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "asd1");
Console.WriteLine(res);

string Method4_1(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res1 = Method4_1(10, "dsa1");
Console.WriteLine(res1);

//Вывод таблицы умножения на экран

for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.Write($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}

/*==Работа с текстом
Дан текст. В тексте нужно пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие "С" - маленькими "с"
*/

string text = "- Я думаю, - сказал князь, улыбаясь - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

/* string s = "qwerty"
               012
s[3] == r
*/

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}


string newText = Replace(text, ' ', '|');
newText = Replace(newText,'к','К');
newText = Replace(newText,'C','c');

Console.WriteLine(newText);

/* Сортировка массива */

int[] arr = {1, 5, 4, 3, 2, 7, 6, 1, 1};

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i+1 ; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

void SelectionSort1(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i+1 ; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }


        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
Console.WriteLine();
PrintArray(arr);
SelectionSort1(arr);
Console.WriteLine();
PrintArray(arr);