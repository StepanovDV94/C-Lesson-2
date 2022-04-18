int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int a1 = 12, a2 =154, a3 = 25,
    a4 = 9, a5 = 34, a6 = 17,
    a7 = 3, a8 = 99, a9 = 34;

int max = Max(Max(a1,a2,a3),Max(a4,a5,a6),Max(a7,a8,a9));

Console.WriteLine (max);