int mod()
{
    int num = -4356;

    int a = num * -1;
    int b = num / 1000;
    int c = (b * 1000);
    int d = (a - c);
    int e = (d / 100);
    int f = (e * 100);
    int g = (d - f);
    int result = (g / 10);
    return (result);
}
Console.WriteLine(mod());