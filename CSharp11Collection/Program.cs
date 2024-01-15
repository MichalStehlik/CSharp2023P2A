using System.Collections;

Student tonda = new Student { Name = "Antonín" };
ArrayList al = new ArrayList();
al.Add("Ahoj");
al.Add(10);
al.Add(tonda);
foreach(var x in al)
{
    if (x is Student)
    {
        Console.WriteLine((x as Student).Name);
    }
}

List<Student> list = new List<Student>();
list.Add(tonda);
list.Add(new Student { Name = "Honza"});
list.Add(new Student { Name = "Štěpán" });
foreach (var x in list)
{
    Console.WriteLine(x.Name);
}
list.Add(new Student { Name = "Ondřej" });
list.Remove(tonda);
list.Sort();
foreach (var x in list)
{
    Console.WriteLine(x.Name);
}
list.Reverse();
Console.WriteLine(list.Count);
Console.WriteLine(list.Capacity);
Console.WriteLine(list[0].Name);
list.Add(tonda);
list.Add(tonda);
Console.WriteLine(list.Contains(tonda));
Console.WriteLine(list.IndexOf(tonda));
Console.WriteLine(list.LastIndexOf(tonda));
list.AddRange(list);
foreach (var x in list)
{
    Console.WriteLine(x.Name);
}
list.Insert(3, new Student { Name = "Bořivoj" });
list.RemoveAt(4);
Console.WriteLine();  
foreach (var x in list)
{
    Console.WriteLine(x.Name);
}
ICollection<Student> students = list.ToList();

Dictionary<string, Student> members = new Dictionary<string, Student>();
members.Add("tonda1",tonda);
members.Add("tonda2", tonda);
members.Add("petr", new Student { Name = "Petr"});
Console.WriteLine(members["tonda2"].Name);
if (members.ContainsKey("tonda7"))
{
    Console.WriteLine(members["tonda7"].Name);
}
foreach(var x in members)
{
    Console.WriteLine(x.Key + " " + x.Value);
}

Queue<Student> queue = new Queue<Student>();
queue.Enqueue(tonda);
queue.Enqueue(new Student { Name = "Štěpán"});
Console.WriteLine(queue.Dequeue().Name);

Stack<Student> stack = new Stack<Student>();
stack.Push(tonda);
stack.Push(new Student { Name = "Štěpán" });
Console.WriteLine(stack.Pop().Name);

class Student: IEquatable<Student>, IComparable<Student>
{
    public string Name { get; set; }

    public int CompareTo(Student? other)
    {
        if (this.Name == other.Name) return 0;
        if (this.Name.Length > other.Name.Length) return 1;
        return -1;
    }

    public bool Equals(Student? other)
    {
        if (this.Name == other.Name) return true;
        return false;
    }
}