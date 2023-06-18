void Palindrome(int num)
{
    int num1 = num / 10000;
    int num2 = num % 10000 / 1000;
    int num3 = num % 1000 / 100;
    int num4 = num % 100 / 10;
    int num5 = num % 10;
    if (num1 == num5 && num2 == num4)
    {
        System.Console.WriteLine("Ваше число палиндром");
    }
    else
    {
        System.Console.WriteLine("Ваше число не палиндром");
    }
}

// int number = new Random().Next(10000, 100000);
// System.Console.WriteLine($"Ваше случайное число: {number}");
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);