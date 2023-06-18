void PossCoor(int num)
{
    if (num == 1)
    {
        System.Console.Write("Диапазон точек: {x>0;y>0}");
    }
    else if (num == 2)
    {
        System.Console.Write("Диапазон точек: {x<0;y>0}");
    }
    else if (num == 3)
    {
        System.Console.Write("Диапазон точек: {x<0;y<0}");
    }
    else if (num == 4)
    {
        System.Console.Write("Диапазон точек: {x>0;y<0}");
    }
    else
    {
        System.Console.Write("Области с таким номером нет в двумерной системе координат");
    }
}

System.Console.Write("Введите номер координатной четверти: ");
int number = Convert.ToInt32(Console.ReadLine());


PossCoor(number);