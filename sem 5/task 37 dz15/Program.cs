int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random a = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a.Next(-99 , 100);
    }
    return arr;
}

System.Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
System.Console.WriteLine($"[{string.Join("; ", array)}]");

int result = 0;
 for (int i = 1; i < array.Length; i = i + 2)
{
    result = result + array[i];
}
System.Console.WriteLine($"сумма чисел, стоящих на нечетных позициях : {result}");