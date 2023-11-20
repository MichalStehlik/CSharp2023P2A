// See https://aka.ms/new-console-template for more information
using CSharp06Polymorphism;

Animal x = new Animal();
Console.WriteLine(x.MakeSound());
Console.WriteLine(x); // Console.WriteLine(x.ToString());
//Console.WriteLine(x.MakeHappySound());
Dog alik = new Dog();
Console.WriteLine(alik.MakeSound());
Console.WriteLine(alik.MakeHappySound());
Console.WriteLine(alik);
Animal bobik = new Dog();
Console.WriteLine(bobik.MakeSound());
Console.WriteLine(bobik);
//Console.WriteLine(bobik.MakeHappySound());
Animal cici = new Cat();
Console.WriteLine(cici.MakeSound());
Console.WriteLine(cici);
Cat dabel = new Cat();
Console.WriteLine(dabel.MakeSound());
Console.WriteLine(dabel);