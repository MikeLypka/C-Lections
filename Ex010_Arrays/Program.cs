int[] array = {1, 12, 34, 2, 65, 3, 2, 876, 31};

int n = array.Length;
int find = 2;
int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}