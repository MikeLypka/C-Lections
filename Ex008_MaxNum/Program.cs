int a1 = 23;
int b1 = 24;
int c1 = 34;
int a2 = 42;
int b2 = 1234;
int c2 = 983;
int a3 = 1;
int b3 = 13;
int c3 = 462;

int MaxNum(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int max1 = MaxNum(a1, b1, c1);
// int max2 = MaxNum(a2, b2, c2);
// int max3 = MaxNum(a3, b3, c3);
// int max = MaxNum(max1, max2, max3);
int max = MaxNum(
    MaxNum(a1, b1, c1),
    MaxNum(a2, b2, c2),
    MaxNum(a3, b3, c3)
);

Console.Write(max);