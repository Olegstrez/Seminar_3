// Задача 21

// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53 
Console.WriteLine("Введите координаты i1");
double i1 = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите координаты J1");
double  j1 = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите координаты z1");
double  z1 = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите координаты i2");
double i2 = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите координаты J2");
double j2 = Convert.ToDouble( Console.ReadLine());
Console.WriteLine("Введите координаты z2");
double z2 = Convert.ToDouble( Console.ReadLine());
double Method1 (double i1, double j1, double z1,double i2, double j2, double z2)
{
    double result ;
    result = Math.Sqrt(Math.Pow(i2-i1,2)+Math.Pow(j2-j1,2)+Math.Pow(z2-z1,2));
    return result;



}
double s = Method1(i1, j1, z1, i2, j2, z2) ;
Console.WriteLine("Итого =" + s);