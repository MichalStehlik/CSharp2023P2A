// See https://aka.ms/new-console-template for more information
using System.Globalization;

DateTime n = DateTime.Now;
Console.WriteLine(n);
DateTime nu = DateTime.UtcNow;
Console.WriteLine(nu);
DateTime n1 = new DateTime(2000,2,10,7,20,15);
Console.WriteLine(n1);
Console.WriteLine(n1.Year);
DateTime n2 = n.AddDays(7);
Console.WriteLine(n2);
TimeSpan s = DateTime.Now - new DateTime();
Console.WriteLine(s.TotalDays);
Console.WriteLine(s.Days);
Console.WriteLine(n.Ticks);
Console.WriteLine(DateTime.DaysInMonth(2024,3));
Console.WriteLine(DateTime.IsLeapYear(2024));
DateTime victory = new DateTime(2024,6,25,12,0,0);
TimeSpan x = victory - n;
Console.WriteLine(x.TotalDays);
Console.WriteLine(n);
Console.WriteLine(n.ToLongDateString());
Console.WriteLine(n.ToString("d",CultureInfo.GetCultureInfo("en-US")));
Console.WriteLine(n.ToString("d", CultureInfo.GetCultureInfo("mi-NZ")));
// 2024-03-11T13:18:00+1
