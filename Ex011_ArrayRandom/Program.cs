void FillArray(int[] SomeArray)
{
    int lenght = SomeArray.Length;
    int index = 0;
    while (index < lenght)
    {
        SomeArray[index] = new Random().Next(1, 10);
        index++;
    }     
}

void PrintArray(int[] massive)
{
    int count = massive.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(massive[position]);
        position++;
    }
}

int FindIndex(int[] SomeArray, int find)
{
    int lenght = SomeArray.Length;
    int index = 0;
    int position = -1;
    while (index < lenght)
    {
        if (SomeArray[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = FindIndex(array, 4);
Console.WriteLine(pos);
