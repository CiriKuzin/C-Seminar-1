int SumToA(int a)
{
    int result = 0;
    for (int i = 1; i <= a; i++)
    {
        result = result + i;
    }
    System.Console.WriteLine($"Сумма чисел от 1 до {a} равна {result}");
    return result;
}

System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

SumToA(A);