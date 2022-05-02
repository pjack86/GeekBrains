int GetNumber()
{
    int num = 766;

    int a = num / 100;

    int b = (a * 100);
    int result = (num - b) / 10;
    return (result);
}
Console.WriteLine(GetNumber());



