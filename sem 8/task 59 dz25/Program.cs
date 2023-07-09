void CreateMatrix (int [,] matrix)
{
    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0,10);
            System.Console.Write($"{matrix[i,j],3} ");
        }
    System.Console.WriteLine();
    }
}

void MultiplicationMatrix (int [,] mtrx1, int [,] mtrx2)
{
    int row = mtrx1.GetLength(0);
    int col = mtrx2.GetLength(1);
    int[,] resultmatrix = new int [row, col];
    if (mtrx1.GetLength(1) == mtrx2.GetLength(0))
    {
        for (int i = 0; i < mtrx1.GetLength(0); i++)
        {
            for (int j = 0; j <mtrx2.GetLength(1); j++)
            {
                for (int k = 0; k < mtrx2.GetLength(0); k++)
                {
                    resultmatrix[i, j] = resultmatrix[i, j] + mtrx1[i,k] * mtrx2[k,j];
                }
                System.Console.Write($"{resultmatrix[i, j],4} ");
            }
            System.Console.WriteLine();
        }
    }
    else
    {
        System.Console.Write("Перемножение данных матриц не возможно");
    }
}

System.Console.Write("Введите кол-во строк первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов первой матрицы: ");
int column1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во строк второй матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов второй матрицы: ");
int column2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int [row1, column1];
int[,] matrix2 = new int [row2, column2];
CreateMatrix(matrix1);
System.Console.WriteLine(" * ");
CreateMatrix(matrix2);
System.Console.WriteLine(" = ");
MultiplicationMatrix(matrix1,matrix2);