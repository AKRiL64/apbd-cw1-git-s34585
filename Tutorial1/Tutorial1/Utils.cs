namespace Tutorial1;

public class Utils
{
    public static ValuableItem AddTwoItems(ValuableItem item1, ValuableItem item2)
    {
        return new ValuableItem(item1.value + item2.value);
    }
}