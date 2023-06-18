void SqrSearch(int num1, int num2)
{
    if (num1 == num2 * num2 || num2 == num1 * num1)
    {
        System.Console.WriteLine("ДА");
    }
    else
    {
        System.Console.WriteLine("НЕТ");;
    }
}


System.Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
SqrSearch(number1, number2);