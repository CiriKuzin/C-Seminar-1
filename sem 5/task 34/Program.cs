int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random a = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a.Next(0 , 1000);
    }
    return arr;
}

System.Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[] array = CreateArray(length);
System.Console.WriteLine($"[{string.Join("; ", array)}]");
System.Console.WriteLine();
System.Console.Write("Введите нижний предел диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите нижний предел диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= min &&  array[i] <= max)
    {
        result = result + 1;
    }
}
System.Console.WriteLine();
System.Console.Write($"Массив содержит {result} элементов находящихся в диапазоне [{min},{max}]");