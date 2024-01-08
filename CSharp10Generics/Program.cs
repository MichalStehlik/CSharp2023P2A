using CSharp10Generics;

var a = new IntStorage(10);
a.Add(1);
Console.WriteLine(a.Value);
var b = new FloatStorage(10.4f);
b.Add(1);
Console.WriteLine(b.Value);
var c = new Storage<int>(40);
Console.WriteLine(c.Value);
var d = new Storage<int>(40);
Console.WriteLine(d.Equals(c));
// ---
var store = new List<int>();
store.Add(1);
store.Add(2);
store.Add(5);
store.Add(3);
store.Add(4);
store.Remove(3);
foreach (var item in store)
{
    Console.WriteLine(item);
}
store.Sort();
foreach (var item in store)
{
    Console.WriteLine(item);
}
// ---
Dictionary<string, string> data = new Dictionary<string, string>();
data.Add("a", "Alpha");
data.Add("b", "Beta");
data.Add("c", "Gamma");
Console.WriteLine(data["b"]);