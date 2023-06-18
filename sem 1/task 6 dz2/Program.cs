Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.Write($"Наибольшее число {numberA}");
}
else if (numberB > numberA && numberB > numberC)
{
    Console.Write($"Наибольшее число {numberB}");
}
else
{
    Console.Write($"Наибольшее число {numberC}");
}