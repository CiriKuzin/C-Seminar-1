void FibNum (int num)
{
    int[] Array = new int[num];
    Array[0] = 0;
    Array[1] = 1;
    System.Console.Write($"первые {num} числа(ел) Фибоначчи: {Array[0]} {Array[1]} ");
    for (int i = 2; i < num; i++)
    {
        Array[i] = Array[i - 1] + Array[i - 2];
        System.Console.Write($"{Array[i]} ");
    }
    
}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
FibNum(number);