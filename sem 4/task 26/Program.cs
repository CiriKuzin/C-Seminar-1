int MultToN(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    System.Console.WriteLine($"Произведение чисел от 1 до {num} равно {result}");
    return result;
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

MultToN(number);