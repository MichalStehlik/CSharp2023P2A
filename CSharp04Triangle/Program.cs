using CSharp04Triangle;

try
{
    Triangle x = new Triangle(0, 0, 0);
}
catch (Exception ex)
{
    Console.WriteLine("Trojúhelník se nepodařilo sestrojit: " + ex.Message);
}

Triangle y = new Triangle(3, 4, 5);
Console.WriteLine(y.Area);
