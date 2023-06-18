void DistPoint(double x1, double y1, double x2, double y2)
{
    System.Console.Write($"Расстояние между точками A ({x1}, {y1}) и B ({x2}, {y2}) равно {Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),2)}");
}

System.Console.Write("Введите координату X точки A: ");
int Ax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки A: ");
int Ay = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату X точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());

DistPoint(Ax, Ay, Bx, By);