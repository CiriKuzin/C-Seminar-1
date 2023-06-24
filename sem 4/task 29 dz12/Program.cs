int SumNum(int num)
{
    int length = num.ToString().Length;
    int[] array = new int [length];
    int result = array[0];
    int a = 1;
    for (int i = 0; i < length; i++)
    {
        a = a * 10;
    }

    for (int i = 0; i < length; i++)
    {
        array[i] = (num % a) / (a / 10);
        a = a / 10;
        result = result + array[i];
    }
    System.Console.WriteLine($"Cумма цифр числа {num} равна {result}");
    return result;
}

System.Console.Write("Число: ");
int number = Convert.ToInt32(Console.ReadLine());
SumNum(number);
