Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA % 2;

if (numberB == 0)
{
    Console.Write($"Число {numberA} чётное");
}
else 
{
    Console.Write($"Число {numberA} нечётное");
}