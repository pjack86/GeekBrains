// Предпологаю что работаем с целыми числами

int a = 1;
int N = 33;

if (a % 2 == 1)
{
    a += 1;
}

while (a < (N - 1))
{
    a = a + 2;
    Console.WriteLine (a);
}