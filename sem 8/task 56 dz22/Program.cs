void CreateMatrix (int [,] matrix)
{
    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0,99);
            System.Console.Write($"{matrix[i,j],3} ");
        }
        System.Console.WriteLine();
    }
}

void SortMatrix (int [,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
                if (matrix[i,k] < matrix[i,k+1])
                {
                    temp = matrix[i,k];
                    matrix[i,k] = matrix[i,k+1];
                    matrix[i,k+1] = temp;
                }
            }
        }
    }
}

void PrintNewMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j],3} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [row, column];
System.Console.WriteLine();
System.Console.WriteLine("Исходный массив: ");
CreateMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine("Отсортированный массив: ");
SortMatrix(matrix);
PrintNewMatrix(matrix);