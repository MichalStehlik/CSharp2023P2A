using CSharp08Interface;

Reader tonda = new Reader { Name = "Antonín" };
Book bab = new Book { Name = "Babička", Content = "Něco s nějakou starou paní splavem."};
Book lotr = new Book { Name = "Pán prstenů", Content = "Něco s nějakým prstenem a trpaslíkama." };
Newspaper dnes = new Newspaper { Content = "Někdo něco chytrého řekl"};
Magazine blesk = new Magazine { Content = "Agáta Hanychová"};
Console.WriteLine(tonda.Read(blesk));
Console.WriteLine(tonda.Read(bab));
Console.WriteLine(tonda.Read(dnes));
Console.WriteLine(bab.CompareTo(lotr));
/*
IComparable - <, >
IEquitable - ==, !=
IEnumerable - foreach
IDisposable
IEnumerator
*/