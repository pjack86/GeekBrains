//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да


int[] arrey = { 1, 4, 2, 4, 3 };
int a = arrey[0];
int b = arrey[1];
int c = arrey[2];
int d = arrey[3];
int e = arrey[4];

if (a == e)
{
    if (b == d)
    {
        Console.WriteLine ("Да");
    }
}
else
{
    Console.WriteLine("Нет");
}
