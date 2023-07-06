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

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [row, column];
CreateMatrix(matrix);

int min = matrix[0,0];
int max = matrix[0,0];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (min > matrix[i,j])
        {
            min = matrix[i,j];
        }
        if (max < matrix[i,j])
        {
            max = matrix[i,j];
        }
    }
}

int count = 0;

for (int k = min; k <= max; k++)
{
    count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == k)
            {
                count++;
            }
        }
    }
    if (count > 0)
    {
        System.Console.WriteLine($"Число {k,3} встречается {count} раз(а)");
    }
}