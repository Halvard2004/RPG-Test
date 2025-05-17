namespace VideoGame;


public class Player
{
    public int Health;
    public int MaxHealth;
    public int Lvl;
    public Stats Stat = new Stats();
    public Inventory[] Inventory;
    public Equipment[] Equipments;

    public Player()
    {
        Inventory =
        [
            new Inventory(1, 0),
            new Inventory(2, 0),
            new Inventory(3, 0),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
        ];
        Equipments =
        [
            new Equipment("Head"),
            new Equipment("Body"),
            new Equipment("Legs"),
            new Equipment("Feet"),
            new Equipment("Talisman 1"),
            new Equipment("Talisman 2"),
        ];
    }
    
    
}

