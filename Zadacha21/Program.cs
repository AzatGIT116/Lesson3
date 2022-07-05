// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void printCoordinates (double dX,double dY,double dZ, double aX,double aY,double aZ)
{
double x=dX-aX;
double y=dY-aY;
double z=dZ-aZ;
double c=Math.Sqrt(x*x+y*y+z*z);
Console.WriteLine(Math.Round(c,2));
}
printCoordinates(3,6,8,2,1,-7);
