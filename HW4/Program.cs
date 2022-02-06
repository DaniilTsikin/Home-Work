int[] numberA = {1,42,23,432,51,65,77,88,92,103,11,12,113};
int N = numberA.Length;
int index = 0;

while (index < N)
{
    if (numberA[index] % 2 == 0)
    {
        Console.WriteLine(numberA[index]);
    }
    index++;
}


