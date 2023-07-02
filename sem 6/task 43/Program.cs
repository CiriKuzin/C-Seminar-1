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

void CopyArray (int[] arr, int[] newarr)
{
    for (int i = 0; i < newarr.Length; i++)
    {
        newarr[i] = arr[i];
    }
}
System.Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
System.Console.WriteLine(string.Join("; ", array));
int[] NewArray = new int[array.Length];
CopyArray(array, NewArray);
System.Console.WriteLine(string.Join("; ", NewArray));