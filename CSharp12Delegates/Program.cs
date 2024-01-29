// See https://aka.ms/new-console-template for more information
using CSharp12Delegates;

var del = new DelegateExample(7,3);
Console.WriteLine(del.Do(del.Addition));
Console.WriteLine(del.Do(del.Subtraction));
Console.WriteLine(del.Do(del.Multiplication));
Console.WriteLine(del.Do(del.Division));
Console.WriteLine(del.Do(SpecialMath));
Console.WriteLine(del.Do(delegate (float x, float y) { return x * x / y; }));
Console.WriteLine(del.Do((x,y) => { return x * x / y; }));
Console.WriteLine(del.Do((x, y) => (x * x / y))); // lambda op // arrow fce
Console.WriteLine();
List<int> ints = new List<int> {41,14,85,6,87,1,2,4,8,61,2,14,7 };
foreach (int i in ints.Where(x => x > 10)) // LINQ
{
    //if (i > 10)
        Console.WriteLine(i);
}
Console.WriteLine();
foreach (int i in ints.OrderBy(x => x))
{
    //if (i > 10)
    Console.WriteLine(i);
}
Console.WriteLine();
foreach (int i in ints.OrderByDescending(x => x))
{
    Console.WriteLine(i);
}
Console.WriteLine();
foreach (int i in ints.Where(x => x % 2 == 0).OrderBy(x => x))
{
    Console.WriteLine(i);
}
Console.WriteLine();
foreach (int i in ints
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .Select(x => 10*x)
    .Where(x => x > 50))
{
    Console.WriteLine(i);
}
Console.WriteLine();
float SpecialMath(float x, float y)
{
    return x * x * y;
}
