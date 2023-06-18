Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = 0;

if (number % 2 == 0)
    {
        while (x <= 2 * number)
        {
            Console.Write($"{-number+x}, ");
            x = x + 2;
        }
    }
    else
    {
        x = x + 1;
        while (x <= 2 * number)
        {
            Console.Write($"{-number+x}, ");
            x = x + 2;
        }
    }