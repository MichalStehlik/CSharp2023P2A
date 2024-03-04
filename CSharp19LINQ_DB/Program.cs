// See https://aka.ms/new-console-template for more information
using CSharp19LINQ_DB.Data;

Console.WriteLine("Hello, World!");
// Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False

var db = new ApplicationDbContext();
foreach (var item in db.Students)
{
    Console.WriteLine(item.Firstname + " " + item.Lastname);
}

db.Students.Add(new CSharp19LINQ_DB.Models.Student { Firstname = "Daniel", Lastname = "Dobrý"});
db.SaveChanges();

foreach (var item in db.Students.Where(x => x.Lastname.StartsWith("N")))
{
    Console.WriteLine(item.Firstname + " " + item.Lastname);
}

foreach (var item in db.Students.OrderBy(x => x.Lastname))
{
    Console.WriteLine(item.Firstname + " " + item.Lastname);
}