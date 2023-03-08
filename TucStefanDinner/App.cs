public class Person : IGameObject
{
    private int counter = 0;
    private string latestAction = "";

    public static Random Random = new();
    public string Namn { get; set; }

    public int Level { get; private set; } = 1;

    public void Act()
    {
        var items = new[] { "rapar", "äter", "dricker", "pratar" };
        latestAction = items[Random.Next(items.Length)];
        Console.WriteLine($"Level {Level} {Namn} {latestAction}");
    }

    public void CheckIfLevelUp()
    {
        if (latestAction == "rapar") 
            counter++;
        else
            counter = 0;

        if (counter == 3)
        {
            Level++;
            counter = 0;
        }
    }
}

public class Fly : IGameObject
{
    public int Level { get; set; } = 1;
    public string LatestAction { get; set; }
    public static Random Random = new Random();
    public void Act()
    {
        var items = new[] { "flyger", "surrar", "landar i maten" };
        LatestAction = items[Random.Next(items.Length)];
        Console.WriteLine($"Flugan {LatestAction}");
    }

    public void CheckIfLevelUp()
    {
        if (LatestAction == "landar i maten")
            Level++;
    }
}


// SPECIFIKATION, LÖFTE, KONTRAKT 
// i Sverige tvp oinnar på el-plugg
public interface IGameObject
{
    void Act();
    void CheckIfLevelUp();
}

public class Cat : IGameObject
{
    public void Act()
    {
        Console.WriteLine("Katten sover");       
    }

    public void CheckIfLevelUp()
    {
    }
}

//1, Lägg till Katt
//2. Level up!!! - algoritm

public class App
{
    public void Run()
    {
        var gameobjects = new List<IGameObject>();
        gameobjects.Add(new Person{ Namn="Stefan" });
        gameobjects.Add(new Person { Namn = "Josefine" });
        gameobjects.Add(new Person { Namn = "Kerstin" });
        gameobjects.Add(new Fly());
        var cat = new Cat();
        gameobjects.Add(cat);

        while (true)
        {
            foreach (var gameobj in gameobjects)
            {
                gameobj.Act();
            }
            foreach (var gameobj in gameobjects)
            {
                gameobj.CheckIfLevelUp();
            }
        }
    }
}