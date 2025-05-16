namespace VideoGame;

public class Inventory
{
    int amount;
    int itemID;

    public Inventory(int itemSlotID, int amount)
    {
        itemID = itemSlotID;
        this.amount = amount;
    }

    public Inventory()
    {
        itemID = 0;
        amount = 0;
    }
}