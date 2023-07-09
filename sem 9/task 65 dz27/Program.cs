void NumberToOne (int num)
{ 
    if (num == 0)
    {
        return;
    }
    System.Console.Write($"{num} ");
    NumberToOne(num - 1);
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
NumberToOne(number);