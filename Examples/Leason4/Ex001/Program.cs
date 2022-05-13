//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Stepen(int a, int b)
{
    int i = 1;
    int c = a;
    do
    {
        c = c * a;
        i++;
    }
    while (i < b);
    return (c);
}
int c = Stepen(2, 7);
Console.WriteLine(c);