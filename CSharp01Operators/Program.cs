int a = 1 + 2; // a = operator+(a,b);
int b = 3 % 4; // dualni op
bool succ = false;
bool succ2 = !succ; // unární operátor oparator!(a);
Console.WriteLine(a == 3 ? "Trojka" : "Netrojka");
// ternární operátor
int c = a == 3 ? 1 : 2;
int d = a == 3 ? 1 : a == 4 ? 3 : 5;

int e = 4 * 8 / 2 + 7 - 8 / (4 % 5);
int f1 = 3 - 5; // -2
int f2 = 6 - 3; // 3
var g = 3f / 4;
g += 4; // g = g + 4;
var h = 4 == 2 || 4 != 7;
var i = 5 | 3;
var j = new Dato();
//j.Value = 3;
var k = j ?? new Dato();
Console.WriteLine(j!.Value);

int[] l = new int[] { 0, 1, 2};
int[] m = l;
m[0] = 100;
foreach (int y in l)
{
    Console.WriteLine(y);
}
Gender x = Gender.Female;
Console.WriteLine(x);
Console.WriteLine((int)x);

// Funkce
static int Addition(int a, int b) // čistá
{
    return a + b;
}

static string Add(int a) // není čistá
{
    var txt = Console.ReadLine();
    return a + txt;
}

static int[] Roots(int a, int b, int c)
{
    return new int[] { };
}

static void Roots2(int a, int b, int c, out int? x1, out int? x2)
{
    x1 = 0; x2 = 0;
}

int? aa; // int vs int? - nulovatelný dat. typ
int? bb;
Roots2(1,2,3,out aa,out bb);

if (aa is null || bb == null)
{

}

// 101010 - or
// 111111
// 111111

// 101010 - xor
// 111111
// 010101

enum Gender // výčtový typ
{
    Male = 1,
    Female = 2,
    Other = 3,
    DontKnow = 0
}

class Dato
{
    public int Value { get; set; }
}