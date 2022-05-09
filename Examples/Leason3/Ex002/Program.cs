//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.


//double x1 = 3;
//double y1 = 6;
//double x2 = 2;
//double y2 = 1;
double Method(double x1, double y1, double x2, double y2)
{
    double a = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    double c = Math.Sqrt(a);
    return (c);
}
double c = Method (3,6,2,1);
Console.WriteLine (c);