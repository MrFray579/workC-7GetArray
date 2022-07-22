Console.WriteLine("Введите количество строк массива:");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int colums = int.Parse(Console.ReadLine());

int[,] GetArray (int m, int n, int minRandom, int maxRandom)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minRandom, maxRandom+1);

        }
    }
    return result;
}

int[,] array = GetArray(rows, colums, 0, 10);

void PrintArray (int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.Write("\n");
    }
}

PrintArray (array);

void ChangeRows (int [,] matrix)
{
    int numberlastRow = matrix.GetLength(0) - 1; // последнее число массива
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[numberlastRow, i];
        matrix[numberlastRow, i] = temp;
    }
}

ChangeRows (array);
Console.WriteLine("Результат:");
PrintArray (array);