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
System.Console.WriteLine($"[{string.Join("; ", array)}]");

System.Console.Write("Задайте искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 0;
int result = 0;
while (index < array.Length || result > 0)
{
    if (array[index] == number)
    {
        result = 1;
        break;
    }
    else
    {
        index++;
    }
}

if (result == 1)
{
    System.Console.WriteLine($"Искомое число {number} содержится в массиве");
}
else
{
    System.Console.WriteLine($"Искомого числа {number} в массиве нет");
}