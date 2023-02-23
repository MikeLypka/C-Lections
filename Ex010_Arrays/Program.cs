int[] array = {1, 12, 34, 2, 65, 3, 2, 876, 31};

int find = 31;
int index = 0;

while (index < array.Length)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}