void CreateMatrix (int [,] matrix)
{
    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0,10);
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void ArMean (int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[j] = matrix[i, j];
        }
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[j] = arr[j] + matrix[i, j];
        }
    }
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        arr[i] = arr[i] / matrix.GetLength(0);
        System.Console.Write($"{arr[i]} ");
    }

}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [row, column];
CreateMatrix(matrix);
ArMean(matrix);