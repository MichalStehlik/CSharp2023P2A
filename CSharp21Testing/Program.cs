// See https://aka.ms/new-console-template for more information
using CSharp21Testing;

Calculator calc = new Calculator();
if (calc.Addition(1, 2) == 3) Console.WriteLine("Passed"); else Console.WriteLine("Failed");
