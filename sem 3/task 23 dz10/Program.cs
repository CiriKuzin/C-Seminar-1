void TableOfCube(int num)
{
    for (int i = 0; i < num; i++)
    System.Console.WriteLine($"{i+1} * {i+1} = {Math.Pow(i+1, 3)}");
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableOfCube(number);