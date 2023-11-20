// See https://aka.ms/new-console-template for more information
using CSharp07Abstract;

Book b1 = new Book { Title = "Babička", Author = "Němcová", Chapters = 20};
Media[] items = new Media[]
{
    b1,
    new AudioBook { Title = "1984", Author = "George Orwell", Chapters=10, Length=600},
    new Movie { Title = "Dune", Length = 180},
    new Song { Title = "Victory", Length= 3, Interpret="Thomas Bergersen"}
};
// Media m = new Media { Title = "AAAAAA"};
foreach (var x in items)
{
    Console.WriteLine(x.Show());
}