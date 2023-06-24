int APowB(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++)
    {
        result = result * num1;
    }
System.Console.WriteLine($"{num1} ^ {num2} = {result}");
return result;
}

System.Console.Write("Введите 1 число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 2 число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

APowB(numberA, numberB);