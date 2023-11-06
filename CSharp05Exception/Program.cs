using CSharp05Exception;

int a = 10;
int b = 0;
int c = 0;
try
{
    // uživatelský vstup - TryParse
    // souborové operace
    // databáze, internet
    // hardware
    c = a / b; // -- exception
    Console.WriteLine("Vše OK"); // proběhne jen, pokud není chyba
}
catch(DivideByZeroException ex)
{
    // kód proběhne při chybě
    c = int.MaxValue;
    Console.WriteLine("Dělíš nulou: " + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Neznámá chyba: " + ex.Message);
}
finally
{
    // kód proběhne vždy
    Console.WriteLine("Done.");
}
Console.WriteLine(c);
try
{
    Rectangle x = new Rectangle(0);
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Obdélník nelze sestrojit:" + ex.Message);
}