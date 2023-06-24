System.Console.Write("Задайте размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
Random a = new Random();
int pos = 0;
int neg = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = a.Next(-9 , 10);
    if (array[i] > 0)
    {
        pos = pos + array[i];
    }
    else
    {
        neg = neg + array[i];
    }
}
System.Console.WriteLine($"[{string.Join("; ", array)}]");
System.Console.WriteLine($"Cумма положительных чисел: {pos}");
System.Console.WriteLine($"Cумма отрицательных чисел: {neg}");