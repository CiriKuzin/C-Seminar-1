int CreateMatrix3D (int [,,] matrix)
{
    Random rnd = new Random ();
    int maxnumber = matrix[0,0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)    
            {
                matrix[i, j, k] = rnd.Next(0,50);
                for (int l = 0; l < matrix.GetLength(0); l++)
                {
                    for (int m = 0; m < matrix.GetLength(1); m++)
                    {
                        for (int n = 0; n < matrix.GetLength(2); n++)
                        {
                            if (matrix[l,m,n] == matrix[i,j,k])
                            {
                                matrix[l,m,n] = maxnumber;
                                maxnumber++;
                            }
                        }
                    }
                }
            }
        }
    }
    return maxnumber;
}

int PrintMatrix3D (int [,,] matrix)
{
    Random rnd = new Random ();
    int maxnumber = matrix[0,0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)    
            {
                System.Console.Write($"{matrix[i,j,k],3} ");
            }
        System.Console.Write("   ");
        }
    System.Console.WriteLine();
    }
    return maxnumber;
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во страниц: ");
int page = Convert.ToInt32(Console.ReadLine());
int[,,] matrix3D = new int [row,page,column];
System.Console.WriteLine();
if (CreateMatrix3D(matrix3D) > 100)
{
   System.Console.Write("Массив содержит больше значений, чем того предполагает условие"); 
}
else
{
    PrintMatrix3D(matrix3D);
}
    // Проверка на неповторимость
    // int min = matrix3D[0,0,0];
    // int max = matrix3D[0,0,0];

    // for (int i = 0; i < matrix3D.GetLength(0); i++)
    // {
    //     for (int j = 0; j < matrix3D.GetLength(1); j++)
    //     {
    //         for (int k = 0; k < matrix3D.GetLength(2); k++)
    //         {
    //             if (min > matrix3D[i,j,k])
    //             {
    //                 min = matrix3D[i,j,k];
    //             }
    //             if (max < matrix3D[i,j,k])
    //             {
    //                 max = matrix3D[i,j,k];
    //             }
    //         }
    //     }
    // }

    // int count = 0;

    // for (int l = min; l <= max; l++)
    // {
    //     count = 0;
    //     for (int i = 0; i < matrix3D.GetLength(0); i++)
    //     {
    //         for (int j = 0; j < matrix3D.GetLength(1); j++)
    //         {
    //             for (int k = 0; k < matrix3D.GetLength(2); k++)
    //             {
    //                 if (matrix3D[i,j,k] == l)
    //                 {
    //                     count++;
    //                 }
    //             }
                
    //         }
    //     }
    //     if (count > 1)
    //     {
    //         System.Console.WriteLine($"Число {l,3} повторяется");
    //     }
    // }