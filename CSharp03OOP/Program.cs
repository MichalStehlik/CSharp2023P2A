// See https://aka.ms/new-console-template for more informationvar 
using CSharp03OOP;

var sp = new Book("Společenstvo prstenů");
// sp.title = "";
sp.SetTitle("Společenstvo prstenů");
Console.WriteLine(sp.GetTitle());
var tt = new Book("Dvě věže","JRRT");

Book[] books = new Book[2];
books[0] = sp;
books[1] = tt;
foreach (var book in books)
{
    Console.WriteLine(book.GetName());
}
/*
string[] names = new string[2];
string[] authors = new string[2];
names[0] = "Babička";
authors[0] = "Němcová";
*/