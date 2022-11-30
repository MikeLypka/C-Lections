
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] MyArray = {6, 8, 3, 2, 1, 4, 1, 7, 7};

void PrintArray(int[] array)
{
    int minDigit = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}   

PrintArray(MyArray);

void ArraySort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minDigit = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minDigit]) minDigit = j;      
        }
        
        int temp = array[i];
        array[i] = array[minDigit];
        array[minDigit] = temp;
    }
}

ArraySort(MyArray);

PrintArray(MyArray);