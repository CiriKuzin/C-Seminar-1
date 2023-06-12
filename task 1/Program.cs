Console.Write("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA == NumberB * NumberB)
{
    Console.Write($"Число {NumberA} является квадратом числа {NumberB}");
}
else
{
    Console.Write($"Число {NumberA} не является квадратом числа {NumberB}");
}