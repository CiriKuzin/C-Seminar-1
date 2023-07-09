int PowerToNumber (int num1, int num2)
{
    if (num2 == 0)
    {
        return 1;
    }
    return num1 *= PowerToNumber(num1, num2 - 1);
}

System.Console.Write("Введите основание: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{number1} в степени {number2} равно {PowerToNumber(number1, number2)}");