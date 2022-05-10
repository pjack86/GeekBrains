//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//double x1 = 3;
//double y1 = 6;
//double z1 = 8;
//double x2 = 2;
//double y2 = 1;
//double z2 = -7;

double Method(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    double c = Math.Sqrt(a);
    return (c);
}
double c = Method(3, 6, 8, 2, 1, -7);
Console.WriteLine(c);

