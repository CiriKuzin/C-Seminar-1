void ThirdNum(int num)
{
    int length = num.ToString().Length;
    if (length < 3)
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int[] array = new int [length];
        array[0] = 10;
        for (int i = 1; i < length; i++)
        {
            array[i] = array[i - 1]*10;
        }
        int result = array [^3];
        if (length >= 3)
        {
            System.Console.WriteLine(length);
            System.Console.WriteLine($"Третья цифра числа {num} равна {(num % result) / (result / 10)}");
        }
    }
}


System.Console.Write("Число: ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdNum(number);