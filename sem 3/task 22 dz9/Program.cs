void DistPoint3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double R1 = x2 - x1;
    double R2 = y2 - y1;
    double R3 = z2 - z1;
    double R = Math.Round(Math.Sqrt(Math.Pow(R1, 2) + Math.Pow(R2, 2) + Math.Pow(R3, 2)), 2);
    System.Console.Write($"Расстояние между точками A ({x1},{y1},{z1}) и B ({x2},{y2},{z2}) равно {R}");
}

System.Console.Write("Введите координату X точки A: ");
int Ax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки A: ");
int Ay = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки A: ");
int Az = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату X точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());

DistPoint3D(Ax, Ay, Az, Bx, By, Bz);