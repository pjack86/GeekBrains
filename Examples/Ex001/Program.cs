//Заказчик уточнил что если числа равно то должно выводиться "Большего числа нет"

int a = 5;
int b = 7;

if (a < b)
{
    Console.WriteLine (b);
}

if (a > b)
{
    Console.WriteLine (a);
}

if (a == b)
{
    Console.WriteLine ("Большего числа нет");
}