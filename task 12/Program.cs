void CheckForMult(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        System.Console.WriteLine("ДА");
    }
    else
    {
        System.Console.WriteLine("НЕТ");;
    }
}


System.Console.Write("Число: ");
int number = Convert.ToInt32(Console.ReadLine());
CheckForMult(number);