int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random a = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a.Next(-9 , 10);
    }
    return arr;
}

System.Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
System.Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    array[i] = - array[i];
}
System.Console.WriteLine($"Реверсивный массив: [{string.Join("; ", array)}]");