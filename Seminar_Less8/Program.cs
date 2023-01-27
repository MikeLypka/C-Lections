
Console.WriteLine("Type rows amount: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Type columns amount: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] arrayFirst = GetArray(rows, columns, 0, 10);

PrintArray(array);
Console.WriteLine();

int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void SortArray(int[,] array){
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[array.GetLength(0), j];
        array[array.GetLength(0), j] = temp;
    }
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}