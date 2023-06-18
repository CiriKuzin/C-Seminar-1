Console.Write("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

if (NumberA == 1)
{
    Console.Write("Понедельник");
}
else if (NumberA == 2)
{
    Console.WriteLine("Вторник");
}
else if (NumberA == 3)
{
    Console.WriteLine("Среда");
}
else if (NumberA == 4)
{
    Console.WriteLine("Четверг");
}
else if (NumberA == 5)
{
    Console.WriteLine("Пятница");
}
else if (NumberA == 6)
{
    Console.WriteLine("Суббота");
}
else if (NumberA == 7)
{
    Console.WriteLine("Воскресенье");
}
else if (NumberA > 7 || NumberA < 1)
{
    Console.WriteLine("В неделе 7 дней");
}