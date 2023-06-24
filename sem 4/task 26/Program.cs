int MultToN(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = result * i;
    }
    System.Console.WriteLine($"Произведение чисел от 1 до {n} равно {result}");
    return result;
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

MultToN(N);