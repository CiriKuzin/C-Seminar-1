void NumberToNumber (int num1, int num2)
{
    if (num2 - num1 == -1)
    {
        return;
    }
    NumberToNumber(num1, num2 - 1);
    System.Console.Write($"{num2} ");
}

System.Console.Write("Нижняя граница: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Верхняя граница: ");
int number2 = Convert.ToInt32(Console.ReadLine());
NumberToNumber (number1, number2);
