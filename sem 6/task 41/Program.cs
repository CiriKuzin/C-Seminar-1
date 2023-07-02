void GetBinaryViev (int num)
{
    if (num == 0)
    {
        return;
    }
    else
    {
        GetBinaryViev(num / 2);
        System.Console.Write(num % 2);
    }
}

System.Console.Write("Введите число в десятичной системе: ");
int length = Convert.ToInt32(Console.ReadLine());
GetBinaryViev(length);
