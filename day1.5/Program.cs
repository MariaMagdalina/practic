Console.Clear();
int xa=30, ya=1, xb=1, yb=20, xc=60, yc=20;
Console.SetCursorPosition(xa,ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("*");
int count=0;
int x=xa, y=ya;
while (count<100000)
{
int r=new Random().Next(0,4);
if(r == 0) {x=(x+xa)/2; y=(y+ya)/2;}
if(r == 1) {x=(x+xb)/2; y=(y+yb)/2;}
if(r == 2) {x=(x+xc)/2; y=(y+yc)/2;}
Console.SetCursorPosition(x,y);
Console.WriteLine("*");
count++;
}

