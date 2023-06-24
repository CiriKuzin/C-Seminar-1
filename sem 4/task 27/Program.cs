int[] array = new int[8];
Random a = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = a.Next(0, 2);
}
System.Console.WriteLine($"[{string.Join("; ", array)}]");