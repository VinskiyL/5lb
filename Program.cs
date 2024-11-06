using _5lb;

TranslateSS translateSS = new TranslateSS();
Console.WriteLine(translateSS.Translate(2.5, 2, 4));
string str;
for (int i = 3; i < 23; i++)
{
    if(23%i == 2)
    {
        Console.Write(i + ", ");
    }
}
Console.WriteLine();
Amebs amebs = new Amebs();
Console.WriteLine(amebs.CountTime(8));