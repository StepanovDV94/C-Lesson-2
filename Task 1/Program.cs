int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int  [] array = {1,2,3,4,213,432,45,56,657};

int max = Max(Max(a[0],a[1],a[2]),Max(a[3],a[4],a[5]),Max(a[6],a[7],arg1[8]));

Console.WriteLine (max);