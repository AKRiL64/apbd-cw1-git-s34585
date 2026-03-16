// See https://aka.ms/new-console-template for more information
namespace Tutorial1;
public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Hello, I'm working!");
        ValuableItem item = new ValuableItem(10);
        ValuableItem item2 = new ValuableItem(20);
        ValuableItem item3 = Utils.AddTwoItems(item, item2);
        Console.WriteLine(item3.value);
        Inventory inv = new Inventory();
        inv.AddItem(item);
        inv.AddItem(item2);
        inv.AddItem(item3);
        Console.WriteLine(inv.GetMaxItem().value);
        Console.WriteLine(inv.GetMinItem().value);
    }
}