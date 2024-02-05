// See https://aka.ms/new-console-template for more information
using CSharp17Extension;
using System.Linq;

List<int> ints = new List<int> { 1, 2, 4, 8, 9, 4, 56, 10, 17, 1, 2 };
BetterList ints2 = new BetterList { 1, 2, 4, 8, 9, 4, 56, 10, 17, 1, 2 };
Console.WriteLine(ints2.OddCount());
//Console.WriteLine(ListExtensions.OddCount(ints));
Console.WriteLine(ints.OddCount());
Console.WriteLine(ints.GreaterCount(10));
List<string> names = new List<string> { "Adéla", "Bořislav", "Ctirad", "Diana", "Evžen"};
Console.WriteLine(names.CountItems());
Console.WriteLine(ints.CountItems());
Console.WriteLine();
foreach(var x in ints.Odd())
{
    Console.WriteLine(x);
}
foreach (var x in ints.GreaterThen(10))
{
    Console.WriteLine(x);
}
foreach (var x in ints.Where(q => q > 10))
{
    Console.WriteLine(x);
}
foreach (var x in ints.Where(q => q > 10).OrderBy(q => q))
{
    Console.WriteLine(x);
}