int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random a = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a.Next(100 , 1000);
    }
    return arr;
}

System.Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
System.Console.WriteLine($"[{string.Join("; ", array)}]");

int result = 0;
 for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        result = result + 1;
    }
}
System.Console.WriteLine($"Количество четных чисел в масиве : {result}");