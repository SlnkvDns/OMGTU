using System;


class Program
{
    static void Main()
    {
        Planet Earth = new Planet("Earth", 1);
        Planet Saturn = new Planet("Saturn", 10);
        Planet Mars = new Planet("Mars", 2);
        Planet Neptun = new Planet("Neptun", 2);
        Planet Jupiter = new Planet("Jupiter", 63);
        Planet[] planets = { Earth, Saturn, Neptun, Mars, Jupiter };
        Array.Sort(planets);
        Array.Reverse(planets);
        Console.WriteLine("Планета\tСпутники");
        foreach (Planet planet in planets) Console.WriteLine($"{planet.name}\t{planet.sputnik}");
    }
}

class Planet: IComparable<Planet>
{
    public string name;
    public int sputnik;

    public Planet(string name, int sputnik)
    {
        this.name = name;
        this.sputnik = sputnik;
    }

    public int CompareTo(Planet other)
    {
        return sputnik.CompareTo(other.sputnik);
    }
}