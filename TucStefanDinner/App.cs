

using System.Xml.Linq;

public class Person
{
    public static Random Random = new Random();
    public string Namn { get; set; }

    public void Act()
    {
        var items = new[] { "rapar", "äter", "dricker", "pratar" };
        var latestAction = items[Random.Next(items.Length)];
        Console.WriteLine($"{Namn} {latestAction}");
    }
}

public class App
{
    public void Run()
    {
        var gameobjects = new List<Person>();
        gameobjects.Add(new Person{ Namn="Stefan" });
        gameobjects.Add(new Person { Namn = "Josefine" });
        gameobjects.Add(new Person { Namn = "Kerstin" });
        while (true)
        {
            foreach (var gameobj in gameobjects)
            {
                gameobj.Act();
            }
        }
    }
}