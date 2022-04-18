int [] array = {1,2,3,4,5,6,7,23,234,234,2345,23423,7,23112};

int n = array.Length;

int find = 7;
int index = 0;
while (index<n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}