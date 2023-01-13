Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

int ax = 40;
int ay = 1;
int bx = 1;
int by = 30;
int cx = 80;
int cy = 30;

Console.SetCursorPosition(ax, ay);
Console.WriteLine("+");

Console.SetCursorPosition(bx, by);
Console.WriteLine("+");

Console.SetCursorPosition(cx, cy);
Console.WriteLine("+");

int x = ax, y = bx;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if (what == 0)
    {
        x = (x+ax)/2;
        y = (y+ay)/2;
    }

    if (what == 1)
    {
        x = (x+bx)/2;
        y = (y+by)/2;
    }

    if (what == 2)
    {
        x = (x+cx)/2;
        y = (y+cy)/2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;     // аналог count = count +1  или  count +=1
}