namespace VideoGame;

public class Inventory
{
    public int amount; 
    public int ItemID;

    public Inventory(int itemSlotID, int amount)
    {
        ItemID = itemSlotID;
        this.amount = amount;
    }

    public Inventory()
    {
        ItemID = 0;
        amount = 0;
    }
}