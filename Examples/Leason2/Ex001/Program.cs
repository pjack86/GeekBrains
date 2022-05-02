
int GetNumber()
{
    int num = new Random().Next(10, 100);

    int a = num / 10;
    int b = num % 10;
    Console.WriteLine($" num: {num} a: {a} b: {b}");
    int max = a;

    if (b > max) max = b;
    return (max);
}
Console.WriteLine(GetNumber());