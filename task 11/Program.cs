bool DetOfMult(int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


System.Console.Write("Первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (DetOfMult(number1, number2))
{
    System.Console.Write($"Число {number2} кратно числу {number1}");
}
else
{
    System.Console.Write($"Число {number2} не кратно числу {number1}, остаток {number1 % number2}");
}