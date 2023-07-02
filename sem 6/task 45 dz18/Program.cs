void InterPoint(double a1, double b1, double a2, double b2)
{
    double x = (b2 - b1) / (a1 - a2);
    double y = (b2 * a1 - b1 * a2) / (a1 - a2);
    System.Console.Write($"Точка пересечения прямых y={a1}x+{b1} и y={a2}x+{b2} имеет координаты ({x},{y})");
}

System.Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
InterPoint(k1, b1, k2, b2);