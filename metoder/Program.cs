using System.Globalization;

static void hello32()
{
    for (int a = 0; a < 32; a++)
    {
        Console.WriteLine($"hello{a + 1}");
    }
}
static void kvadrat(int rot)
{
    Console.WriteLine(rot * rot);
}
static void multi(float a, float b)
{
    Console.WriteLine(a * b);
}
static void rightTriangleArea(int höjd, int bas)
{
    float area2 = höjd * bas;
    Console.WriteLine(area2 / 2);
}
static void circlearea(double r)
{
    Console.WriteLine(r * r * Math.PI);
}
static void getnumberint()
{
    Console.WriteLine("givenumber");
    int truenumber = 0;
    bool num = false;
    while (num == false)
    {
        string text = Console.ReadLine();
        num = int.TryParse(text, out truenumber);
    }
    Console.WriteLine(truenumber * 2);
}
static void getchoice(string a, string b, string c)
{
    Console.WriteLine($"choose {a} or {b} or {c} ");
    string choice = "";
    while (choice != a && choice != b && choice != c)
    {
        choice = Console.ReadLine();
    }
    Console.WriteLine(choice);
}

hello32();
kvadrat(8);
multi(64, 2);
rightTriangleArea(32, 16);
circlearea(12.766152972845847);
getnumberint();
getchoice("coffe","tea","water");
Console.ReadLine();
