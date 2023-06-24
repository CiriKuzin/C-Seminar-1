void Count(int num)
{
    int length = num.ToString().Length;
    System.Console.WriteLine($"Количество цифр в числе {num} равно {length}");
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Count(number);