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
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j )
            {
                count = count + matrix[i,j];
            }
        }
    }
    return count;
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [row, column];
CreateRandomMatrix(matrix);
System.Console.WriteLine();
System.Console.Write($"Сумма элементов находящихся на главной диагонали: {DiagMatrix(matrix)}");