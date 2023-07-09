int SumToNumber (int num)
{
    if (num == 0)
    {
        return 0;
    }
    return num % 10 + SumToNumber(num / 10);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Сумма цифр числа {number} равна {SumToNumber(number)}");