int numberA = new Random().Next(1,11);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,11);
Console.WriteLine(numberB);
int max = numberA;
int min = numberA;

if (max <= numberB)
{
    max = numberB;
}
if (min >= numberB)
{
    min = numberB;
}
Console.WriteLine(max);
Console.WriteLine(min);