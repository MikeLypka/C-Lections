int[] array = {1, 45, 32, 49, 534354, 6783, 7221, 82, 976};

int MaxNum(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
};

int result = MaxNum(
    MaxNum(array[0], array[1], array[2]),
    MaxNum(array[3], array[4], array[5]),
    MaxNum(array[6], array[7], array[8])
);

Console.WriteLine(result);