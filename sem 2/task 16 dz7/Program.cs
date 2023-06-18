void Week(int num)
{
    if (num < 1 || num >7)
    {
        System.Console.Write("Дня недели с таким номером нет");
    }
    else if (num == 6 || num == 7)
    {
        System.Console.Write("ДА");
    }
    else
    {
        System.Console.Write("НЕТ");
    }
}
System.Console.Write("Число: ");
int number = Convert.ToInt32(Console.ReadLine());
Week(number);