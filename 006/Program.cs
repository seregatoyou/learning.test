int b = 2;
int e = 6;
int c = 8;
int a = 4;

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (e > max) max = a;
Console.WriteLine(max);