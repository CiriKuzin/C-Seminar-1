void TableOfSqr(int num)
{
    for (int i = 0; i < num; i++)
    System.Console.WriteLine($"{i+1} * {i+1} = {Math.Pow(i+1, 2)}");
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

TableOfSqr(number);