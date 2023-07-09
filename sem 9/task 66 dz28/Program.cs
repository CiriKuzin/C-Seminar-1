int SumOfNumberMN (int num1, int num2)
{
    if (num2 - num1 == -1)
    {
        return 0;
    }
    return num2 += SumOfNumberMN(num1, num2 - 1);
}

System.Console.Write("Нижняя граница: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Верхняя граница: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Сумма чисел от {number1} до {number2} равна {SumOfNumberMN(number1, number2)}");
