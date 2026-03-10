namespace Tutorial1;

public class Inventory
{
    private ValuableItem[] items;
    int amount = 0;

    Inventory()
    {
        items = new ValuableItem[10];
    }

    public void AddItem(ValuableItem item)
    {
        if (amount >= items.Length - 1) throw new Exception();
        items[amount] = item;
        amount++;
    }
}