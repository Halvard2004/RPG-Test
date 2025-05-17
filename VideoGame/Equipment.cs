namespace VideoGame;

public class Equipment
{
    public string SlotName;
    private int ItemID;

    public Equipment(string SlotString)
    {
        this.SlotName = SlotString;
        this.ItemID = 0;
    }
}