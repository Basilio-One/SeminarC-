int [] array = { 1, 22, 3, 5, 4, 9, 8, 22 };

int n = array.Length;
int find = 22;

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
