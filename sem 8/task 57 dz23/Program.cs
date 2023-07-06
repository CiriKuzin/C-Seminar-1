void CreateMatrix (int [,] matrix)
{
    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-100,100);
            System.Console.Write($"{matrix[i,j],3} ");
        }
        System.Console.WriteLine();
    }
}

void CreateArray (int [,] matrix, int [] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[i] = sum;
        System.Console.WriteLine($"Сумма по {i} строке равна:{array[i],4}");
    }
}

void SearchMinLine (int[] array)
{ 
    int min = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            count = i;
        }
    }
    System.Console.Write($"Наименьшая сумма элементов приходится на {count} строку");
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [row, column];
int[] array = new int [matrix.GetLength(0)];
CreateMatrix(matrix);
System.Console.WriteLine();
CreateArray(matrix, array);
System.Console.WriteLine();
SearchMinLine(array);