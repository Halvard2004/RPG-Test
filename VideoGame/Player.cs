using VideoGame;

HEADERnamespace a;

public class Player
{
    public int Health;
    public int MaxHealth;
    public Stats Stat;
    public Inventory[] inventory;

    public Player()
    {
        inventory = [
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
        ]
        switch (MyGame.Difficulty)
        {
            case "Easy":
                GiveHealth(200);
                
                break;
            case "Medium":
                GiveHealth(150);
                break;
            case "Hard":
                GiveHealth(100);
                break;
            default:
                break;
        }
    }

    public void GiveHealth(int amount)
    {
        MaxHealth = amount;
        Health =  MaxHealth;
    }
    
}

