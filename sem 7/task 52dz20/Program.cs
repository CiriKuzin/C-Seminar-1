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

void PosNum (int[,] matrix)
{
    System.Console.Write("Введите номер строки: ");
    int line = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите номер столбца: ");
    int column = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == line - 1 && j == column - 1)
            {
                System.Console.Write($"В заданной позиции находится число {matrix[i,j]}");
            }
            else
            {
                System.Console.Write($"числа с такими координатами нет");
            }
        }
    }
    
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [row, column];
CreateMatrix(matrix);
PosNum(matrix);
