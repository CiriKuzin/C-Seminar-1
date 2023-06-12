Console.Write("Введите число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
int LastDigit = NumberA % 10;
System.Console.WriteLine($"{NumberA} -> {LastDigit}");