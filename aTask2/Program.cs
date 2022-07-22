int rows = 3;
int colums = 3;

int [,] matrix = new int[rows, colums];

int minValue = int.MaxValue;
int indexRows = 0;
int indexColums = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11); // [0, 10]
        Console.Write(matrix[i, j] + "\t");
        if (minValue > matrix[i,j])
        {
            minValue = matrix[i, j];
            indexRows = i;
            indexColums = j;
        }
    }
    Console.WriteLine();
    
}

Console.WriteLine($"Минимум: {minValue}");
Console.WriteLine();
Console.WriteLine("Результат:");

for (int i = 0; i < rows; i++)
{
    if (i != indexRows)
    {
        for (int j = 0; j < colums; j++)
        {
            if (j != indexColums)
            {
                Console.Write(matrix[i, j] + "\t");
            }
        }
        Console.Write("\n");
    }
}