int numberA = new Random().Next(1,51);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,51);
Console.WriteLine(numberB);
int numberC = new Random().Next(1,51);
Console.WriteLine(numberC);
int max = numberA;
if (max <= numberB)
{
    max = numberB;
}
if (max <= numberC)
{
    max = numberC;
}
Console.WriteLine(max);