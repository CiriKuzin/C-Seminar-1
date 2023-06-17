int DigitComparison(int num)
{
    int Digit1 = num / 10;
    int Digit2 = num % 10;
    int result = 0;
    if (Digit1 > Digit2)
    {
        result = Digit1;
    }
    else
    {
        result = Digit2;
    }
    return result;
}

int number = new Random().Next(10,100);
System.Console.WriteLine($"Ваше случайное число: {number}");
System.Console.WriteLine($"Максимальная цифра числа {number} равна {DigitComparison(number)}");
