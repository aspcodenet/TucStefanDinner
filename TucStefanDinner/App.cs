public class Person : IGameObject
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

public class Fly : IGameObject
{
    public static Random Random = new Random();
    public void Act()
    {
        var items = new[] { "flyger", "surrar", "landar i maten" };
        var latestAction = items[Random.Next(items.Length)];
        Console.WriteLine($"Flugan {latestAction}");
    }
}


public interface IGameObject
{
    void Act();
}

public class App
{
    public void Run()
    {
        var gameobjects = new List<IGameObject>();
        gameobjects.Add(new Person{ Namn="Stefan" });
        gameobjects.Add(new Person { Namn = "Josefine" });
        gameobjects.Add(new Person { Namn = "Kerstin" });
        gameobjects.Add(new Fly());
        while (true)
        {
            foreach (var gameobj in gameobjects)
            {
                gameobj.Act();
            }
        }
    }
}