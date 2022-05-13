//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

long sum(long number)
{
    long result = 0;

    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
long result = sum(11);
Console.WriteLine(result);

