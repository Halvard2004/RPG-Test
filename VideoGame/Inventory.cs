namespace VideoGame;

public class Inventory
{
    public int Amount; 
    public int ItemId;

    public Inventory(Items itemSlotID, int amount)
    {
        ItemId = (int)itemSlotID;
        this.Amount = amount;
    }

    public Inventory()
    {
        ItemId = 0;
        Amount = 0;
    }
}