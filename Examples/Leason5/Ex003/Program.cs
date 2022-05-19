//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
double a1 = 2.3;
double b1 = 1.5;
double c1 = 7.4;
double a2 = 2.8;
double b2 = 5.5;
double c2 = 6.4;
double a3 = 4.3;
double b3 = 9.5;
double c3 = 7.1;

double Max(double arg1, double arg2, double arg3)
{
    double result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


double max1 = Max(a1, b1, c1);
double max2 = Max(a2, b2, c2);
double max3 = Max(a3, b3, c3);
double max = Max(max1, max2, max3);
Console.WriteLine (max);

double Min(double arg1, double arg2, double arg3)
{
    double result = arg1;
    if (arg2 < result) result = arg2;
    if (arg3 < result) result = arg3;
    return result;
}


double min1 = Min(a1, b1, c1);
double min2 = Min(a2, b2, c2);
double min3 = Min(a3, b3, c3);
double min = Min(min1, min2, min3);
Console.WriteLine (min);

double finish = max - min;
Console.WriteLine(finish);
