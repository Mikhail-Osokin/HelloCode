Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");
int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xz = 80, yz = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xz, yz);
Console.WriteLine("+");

int x = xa, y = yb;

int count = 0;

while (count<1000)
{
    int what = new Random().Next(0,3); // [0,3) 0,1,2..
    if (what == 0)
    {
        x = (x + xa)/2;
        x = (y + ya)/2;
    }
    if (what == 1)
    {
        x = (x + xb)/2;
        x = (y + yb)/2;    
    }
        if (what == 1)
    {
        x = (x + xz)/2;
        x = (y + yz)/2;    
    }
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count ++;
}