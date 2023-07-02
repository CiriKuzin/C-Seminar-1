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

void FindMin (int[,] matrix)
{
    int min = matrix[0,0];
    int line = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                column = i;
                line = j;
            }
        }
    }
    System.Console.Write($"Наменьшее число массива {min} имеет координаты [{line},{column}]");
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != column)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != line)
                {
                    System.Console.Write($"{matrix[i,j]} ");
                }
            }
            System.Console.WriteLine();
        }
        
    }
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [row, column];
CreateMatrix(matrix);
FindMin(matrix);