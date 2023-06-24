double[] CreateArray(int size)
{
    double[] arr = new double[size];
    Random a = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = a.Next(-99 , 100)+a.NextDouble();
        arr[i] = Math.Round(arr[i] , 3);
    }
    return arr;
}

System.Console.Write("Задайте размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(length);
System.Console.WriteLine($"[{string.Join("; ", array)}]");

double MaxValue = array.Max<double>();
double MinValue = array.Min<double>();
System.Console.WriteLine($"Максимальный элемент массива : {MaxValue}");
System.Console.WriteLine($"Минимальный элемент массива : {MinValue}");