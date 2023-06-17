int FindMedian(int num)
{
    int result = (num % 100) / 10;
    return result;
}

int number = new Random().Next(100,1000);
System.Console.WriteLine($"Ваше случайное число: {number}");
System.Console.WriteLine($"Средняя цифра числа {number} равна {FindMedian(number)}");