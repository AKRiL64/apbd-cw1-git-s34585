namespace Tutorial1;

public class Inventory
{
    public ValuableItem[] items;
    int amount = 0;

    public Inventory()
    {
        items = new ValuableItem[10];
    }

    public ValuableItem GetItem(int index) {
        return index >= amount ? throw new Exception() : items[index];
    }

    public void AddItem(ValuableItem item)
    {
        if (amount >= items.Length - 1) throw new Exception();
        items[amount] = item;
        amount++;
    }
}