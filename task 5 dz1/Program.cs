Console.Write("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA > NumberB)
{
    Console.WriteLine($"Число {NumberA} больше числа {NumberB}");
}
else
{
    Console.WriteLine($"Число {NumberB} больше числа {NumberA}");
}