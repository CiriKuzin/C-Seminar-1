System.Console.Write("Число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
Random a = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = a.Next(-100 , 100);
}
System.Console.WriteLine($"[{string.Join("; ", array)}]");