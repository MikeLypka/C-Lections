int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 13;
int b1 = 234;
int c1 = 9;
int a2 = 4;
int b2 = 53;
int c2 = 2;
int a3 = 9343;
int b3 = 1;
int c3 = 7;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max1 = Max(a3, b3, c3);

Console.WriteLine(max1);