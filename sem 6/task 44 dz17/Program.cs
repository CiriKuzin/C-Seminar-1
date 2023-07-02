int[] CreateArray(int size)
{
    int[] arr = new int[size];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
        if (arr[i] > 0)
        {
            count = count + 1;
        }
    }
    System.Console.Write($"Среди чисел {count} положительных");
    return arr;
}

System.Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);