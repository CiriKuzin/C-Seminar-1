Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int X = 0;

while (X <= 2 * Number)
{
    Console.Write($"{-Number+X}, ");
    X++;
}