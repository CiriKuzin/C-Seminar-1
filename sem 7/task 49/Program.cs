void CreateRandomMatrix (int [,] matrix)
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

int DiagMatrix(int[,] matrix)
{
    int sum = 0;
    System.Console.Write("Числа находящиеся на главной диагонали: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j )
            {
                sum = sum + matrix[i,j];
                System.Console.Write(matrix[i,j] + " ");
            }
        }
    }
     System.Console.WriteLine();
    return sum;
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [row, column];
CreateRandomMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов находящихся на главной диагонали: {DiagMatrix(matrix)}");