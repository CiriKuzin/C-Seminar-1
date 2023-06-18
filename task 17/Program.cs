void CoorArea(int num1, int num2)
{
    if (num1 > 0 && num2 > 0)
    {
        System.Console.Write("Точка располагается в первой четверти");
    }
    else if (num1 < 0 && num2 > 0)
    {
        System.Console.Write("Точка располагается во второй четверти");
    }
    else if (num1 < 0 && num2 < 0)
    {
        System.Console.Write("Точка располагается в третьей четверти");
    }
    else
    {
        System.Console.Write("Точка располагается в четвертой четверти");
    }
}

System.Console.Write("Введите значение X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение Y: ");
int y = Convert.ToInt32(Console.ReadLine());

CoorArea(x,y);