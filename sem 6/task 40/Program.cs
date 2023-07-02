void Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        System.Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} существует");  
    }
    else
    {
        System.Console.WriteLine($"Треугольника со сторонами {a}, {b} и {c} не существует");
    }
}

int number1 = new Random().Next(0,100);
System.Console.WriteLine($"Первая сторона треугольника: {number1}");
int number2 = new Random().Next(0,100);
System.Console.WriteLine($"Первая сторона треугольника: {number2}");
int number3 = new Random().Next(0,100);
System.Console.WriteLine($"Первая сторона треугольника: {number3}");
Triangle(number1, number2, number3);