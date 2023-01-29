int Max(int arg1, int arg2)
{
    int result = arg1;
if (arg2 > result) result = arg2;
return result;
}
        //       0  1  2  3  4  5  6  7  8
int [] array = {11,21,31,41,15,16,71,18,19};
/*array[0] = 12;
Console.WriteLine(array[4]);

int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);
*/
int max = array[0];
int i = 1;

while (i<=array.Length-1)
{
    max = Max(array[i-1],array[i]);
    i++;
}

Console.WriteLine($"Максимальное число = {max}");
