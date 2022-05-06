string Mod(int a, int b)
{
    if (a % b == 0)
    {
        return ("Да, кратное");
    }
    else
    {
        int o = (a % b);
        return ($"Нет, Не кратное. Остаток: {o}");
    }
}
int a = 34;
int b = 5;

string result = Mod(a, b);
Console.WriteLine(result);