namespace Tutorial1;

public class BetterUtils: Utils
{
    public static ValuableItem GetCheaperItem(ValuableItem item1, ValuableItem item2)
    {
        return item1.value <= item2.value? item1:item2;
    }
}