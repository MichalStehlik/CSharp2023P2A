using CSharp04Properties;

Human adam = new Human("Adam","Antoš");
// adam.firstname = "Alois";
adam.SetFirstName("Albert");
Console.WriteLine(adam.GetFirstName());
adam.FirstName = "Adolf";
adam.FirstName = "Andrej";
Console.WriteLine(adam.FirstName);
Console.WriteLine(adam.FullName);