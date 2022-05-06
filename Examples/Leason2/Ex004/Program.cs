string Mod(int a)
{
    int b = 7;
    int c = 23;
    if ((a % b) > 0)
    {
        return ("Нет");
    }
    else if ((a % c) > 0)
    {
        return ("Нет");
    }
    else
    {
        return ("ДА");
    }
}

int a = 161;
string result = Mod(a);
Console.WriteLine(result);