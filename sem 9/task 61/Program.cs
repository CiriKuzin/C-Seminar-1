void OneToNumber (int num)
{
    if (num == 0)
    {
        return;
    }
    OneToNumber(num - 1);
    System.Console.Write($"{num} ");
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
OneToNumber(number);