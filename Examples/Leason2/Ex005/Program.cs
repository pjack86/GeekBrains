
string Mod(int a, int b)
{
    if (a * a == b)
    {
        return ("Да");
    }
    else if (b * b == a)
    {
        return ("Да");
    }
    else
    {
        return ("Нет");
    }
}

int a = 25;
int b = 5;
string result = Mod(a,b);
Console.WriteLine(result);