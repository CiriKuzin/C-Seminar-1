void CreateMatrix (int [,] matrix)
{
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0; // На сколько уменьшается каждый витьк спирали
    int restOfTheWay = matrix.GetLength(1); // Начальная длина хода спирали до изгиба
    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;
        --restOfTheWay;
        if (restOfTheWay == 0) // Если  длина хода спирали до изгиба закончилась
        {
            restOfTheWay = matrix.GetLength(1) * (dirChanges % 2) + matrix.GetLength(0) 
            * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2; // Задается новая длина
            int temp = dx;
            dx = -dy;
            dy = temp; // Смена направления хода спирали
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 10)
            {
                System.Console.Write($" 0{matrix[i,j]} ");
            }
            else
            {
                 System.Console.Write($"{matrix[i,j],3} ");
            }
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
PrintMatrix(matrix);