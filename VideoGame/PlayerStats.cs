namespace VideoGame;

public class PlayerStats
{
    
    public static void StatVariables(int amount)
    {
        int strengthGive = 0;
        int healthGive = 0;
        int agilityGive = 0;
        ShareStats(strengthGive, healthGive, agilityGive, amount);
    }
    
    public static void GiveHealth(int amount)
    {
        MyGame.Player.MaxHealth = amount;
        MyGame.Player.Health =  MyGame.Player.MaxHealth;
    }
    
    public static void ShareStats(int strengthGive, int healthGive, int agilityGive, int amount)
    {
        Console.WriteLine($"Stat Points to give: {amount}");
        Console.WriteLine($"Strength: {Stats.Strength}");
        Console.WriteLine($"Agility: {Stats.Agility}");
        Console.WriteLine($"Health: {Stats.Health}");

        if (amount > 0)
        {
            DecideStat(strengthGive, healthGive, agilityGive, amount);
        }
        
        
        
    }

    public static void DecideStat(int strengthGive, int healthGive, int agilityGive, int amount)
    {
        Console.WriteLine("""
                          Which stat do you want to give or remove
                          1) Strength
                          2) Agility
                          3) Health
                          """
        );
        ConsoleKeyInfo input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.D1)
        {
            AmountStat(strengthGive, amount);
            return;
        } 
        else if (input.Key == ConsoleKey.D2)
        {
            AmountStat(agilityGive, amount);
            return;
        } 
        else if (input.Key == ConsoleKey.D3)
        {
            AmountStat(healthGive, amount);
            return;
        }
        else;
        {
            DecideStat(strengthGive, healthGive, agilityGive, amount);
        }
    }

    public static void AmountStat(int stat, int amount)
    {
        Console.WriteLine($"""
                           Add or Remove StatPoints {stat}
                           1) Add
                           2) Remove
                           """
        );
        ConsoleKeyInfo readKey = Console.ReadKey(true);
        switch (readKey.Key)
        {
            case ConsoleKey.D1:
                stat += 1;
                break;
            case ConsoleKey.D2:
                stat += 5;
                break;
            default:
                AmountStat(stat, amount);
                return;
        }
        
        Console.WriteLine($"""
                          How much
                          1) 1
                          2) 5
                          3) {amount}
                          """
        );
        ConsoleKeyInfo input = Console.ReadKey(true);
        switch (input.Key)
        {
            case ConsoleKey.D1:
                stat += 1;
                break;
            case ConsoleKey.D2:
                stat += 5;
                break;
            case ConsoleKey.D3:
                stat += amount;
                break;
            default:
                AmountStat(stat, amount);
                return;
        }
        
        
    }
}