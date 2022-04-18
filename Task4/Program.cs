void FillArray(int [] collection)
{
    int length = collection.Length;
    int index =0;
    while (index<length)
    {
        collection[index]= new Random().Next(1,10);
        index++;
    }
}

void PrintArray (int [] coll)
{
    int count = coll.Length;
    int Position =0;
    while (Position < count)
    {
        Console.WriteLine(coll[Position]);
        Position++;
    }
}

int IndexOff (int [] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int Position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            Position = index;
            break;
        }        
        
        index++;
    }
    return Position;
}

int [] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 4);
Console.WriteLine(pos);