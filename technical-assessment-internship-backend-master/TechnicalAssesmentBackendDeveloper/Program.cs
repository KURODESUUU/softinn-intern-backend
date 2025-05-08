class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Item Manager!");

        ItemManager manager = new ItemManager();

        // Part One: Fix the NullReferenceException
        // This will throw a NullReferenceException
        Console.WriteLine("Part One:");
        manager.AddItem("Apple");
        manager.AddItem("Banana");

        manager.PrintAllItems();

        // Part Two: Implement the RemoveItem method
        Console.WriteLine("\nPart Two: ");
        manager.RemoveItem("Apple");

        manager.PrintAllItems();

        // Part Three: Introduce a Fruit class and use the ItemManager<Fruit> to add a few fruits and print them on the console.
        // TODO: Implement this part three.
        ItemManager<Fruit> fruitManager = new ItemManager<Fruit>();
        
        Console.WriteLine("\nPart Three: ");

        fruitManager.AddItem(new Fruit("Mango"));
        fruitManager.AddItem(new Fruit("Orange"));
        fruitManager.AddItem(new Fruit("Grapes"));

        fruitManager.PrintAllItems();
    }
}

// Part Four (Bonus): Implement an interface IItemManager and make ItemManager implement it.
// TODO: Implement this part four.
public interface IItemManager
{
    void AddItem(string item);
    void PrintAllItems();
    void RemoveItem(string item);
    void ClearAllItems();
}

public class ItemManager
{
    private List<string> items;

    // Part One: Fix the NullReferenceException
    public ItemManager()
    {
        items = new List<string>();
    }

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    // Part Two: Implement the RemoveItem method
    // TODO: Implement this method
    public void RemoveItem(string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
        else
        {
            Console.WriteLine($"Item '{item}' not found.");
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}

// Part Three: Introduce a Fruit class and use the ItemManager<Fruit> to add a few fruits and print them on the console.
public class Fruit
{
    public string Name { get; set; }

    public Fruit(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

public class ItemManager<T>
{
    // Part One: Fix the NullReferenceException
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void PrintAllItems()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void ClearAllItems()
    {
        items = [];
    }
}