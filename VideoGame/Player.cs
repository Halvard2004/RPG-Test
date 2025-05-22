namespace VideoGame;


public class Player
{
    public int Health;
    public int MaxHealth;
    public Level Lvl;
    public PlayerStats Stat = new PlayerStats();
    public Inventory[] Inventory;
    public Equipment[] Equipments;

    public Player()
    {
        Inventory =
        [
            new Inventory(Items.Cash, 0),
            new Inventory(Items.HealthPotion, 0),
            new Inventory(Items.HealthPotionMax, 0),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
            new Inventory(),
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
        Lvl = new Level();
    }
    
    
}

