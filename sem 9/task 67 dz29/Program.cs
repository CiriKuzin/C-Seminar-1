int AckermanFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermanFunction(m-1, 1);
    return AckermanFunction(m-1, AckermanFunction(m, n - 1));
}

System.Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write(AckermanFunction(number1, number2));