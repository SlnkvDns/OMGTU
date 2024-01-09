using System;

class Program
{
    static void Main()
    {
        Ceh a = new Ceh("ceh3", 2004, 100);
        Ceh b = new Ceh("ceh2", 2005, 150);
        Ceh c = new Ceh("ceh1", 2006, 110);
        Ceh d = new Ceh("ceh1", 2004, 100);
        Ceh e = new Ceh("ceh3", 2006, 200);
        Ceh[] cehs = new Ceh[] { a, b, c, d, e };

        Array.Sort(cehs, new CehComparer());
        Console.WriteLine("Цех     Год     Интенсивность");
        foreach (Ceh ceh in cehs)
            Console.WriteLine($"{ceh.name}\t{ceh.year}\t{Math.Round(ceh.numberOfDetails*1.0 / 365, 2)}");
    }

}

class Ceh
{
    public string name;
    public int year;
    public int numberOfDetails;

    public Ceh(string name, int year, int numberOfDetails)
    {
        this.name = name;
        this.year = year;
        this.numberOfDetails = numberOfDetails;
    }
}

class CehComparer: IComparer<Ceh>
{
    public int Compare(Ceh x, Ceh y)
    {
        int nameComparison = x.name.CompareTo(y.name);
        if (nameComparison == 0)
        {
            return x.year.CompareTo(y.year);
        }
        return nameComparison;
    }
}