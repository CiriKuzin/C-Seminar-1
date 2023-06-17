int DelMedian(int num)
{
    int num1 = num / 100;
    int num2 = num / 10;
    int num3 = num % num2;
    int result = 0;
    result = num1*10 + num3;
    return result;
}

int number = new Random().Next(100,999);
System.Console.WriteLine($"Ваше случайное число: {number}");
System.Console.WriteLine($"Получившийся результат от удаление второй цифры из числа {number} равен {DelMedian(number)}");