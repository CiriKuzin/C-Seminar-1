int[] CreateArray(int size)
{
    int[] arr = new int[size];
    Random a = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a.Next(0 , 10);
    }
    return arr;
}

System.Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
System.Console.WriteLine($"[{string.Join("; ", array)}]");

int Newlenght = array.Length / 2 + array.Length % 2;
int[] NewArray = new int[Newlenght];

for (int i = 0; i < array.Length / 2; i++)
{
    NewArray[i] = array[i] * array[array.Length - i - 1];
}
if (NewArray.Length % 2 == 1)
{
    NewArray[Newlenght - 1] = array[Newlenght - 1];
}
System.Console.WriteLine($"[{string.Join("; ", NewArray)}]");