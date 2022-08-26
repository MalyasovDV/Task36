void Output(int[]? array)
{
    for (int i = 0; i < array.Length; ++i)
        Console.WriteLine(array[i]);
}

int SumOddIndexes(int[]? array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

Random rnd = new Random();
int[] array = new int[4];

for (int i = 0; i < array.Length; ++i)
    array[i] = rnd.Next(-100,100);

Output(array);
Console.WriteLine();
Console.WriteLine(SumOddIndexes(array));
