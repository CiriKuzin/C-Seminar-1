void CreateMatrix (int [,] matrix)
{
    Random rnd = new Random ();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0,9);
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void SearchRepet (int [,] matrix, int[] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < array.Length; k++)
            {
                if (matrix[i, j] == k)
                {
                    array[k] = array[k] + 1; 
                }
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

int[] array = new int[] {0,0,0,0,0,0,0,0,0,0};
SearchRepet(matrix, array);

for (int k = 0; k < 10; k++)
{
    if (array[k] > 0)
    {
        System.Console.WriteLine($"{k} встречается {array[k]} раз(а)");
    }
}