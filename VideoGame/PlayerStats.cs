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
    
    public static void SetHealth(int amount, Player unit)
    {
        unit.MaxHealth = amount;
        unit.Health =  unit.MaxHealth;
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
            SelectGiveTakeStat(strengthGive, amount);
            return;
        } 
        else if (input.Key == ConsoleKey.D2)
        {
            SelectGiveTakeStat(agilityGive, amount);
            return;
        } 
        else if (input.Key == ConsoleKey.D3)
        {
            SelectGiveTakeStat(healthGive, amount);
            return;
        }
        else;
        {
            DecideStat(strengthGive, healthGive, agilityGive, amount);
        }
    }

    public static void SelectGiveTakeStat(int stat, int amount)
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
                AmountStat(stat, amount,"Remove");
                break;
            case ConsoleKey.D2:
                AmountStat(stat, amount, "Add");
                break;
            default:
                SelectGiveTakeStat(stat, amount);
                return;
        }
        
    }

    public static void AmountStat(int stat, int amount, string statName)
    {
        int Selected;
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
                Selected = 1;
                break;
            case ConsoleKey.D2:
                Selected = 5;
                break;
            case ConsoleKey.D3:
                Selected = amount;
                break;
            default:
                AmountStat(stat, amount, statName);
                return;
        }

        if (statName == "Add")
        {
            stat += Selected;
        } else if (statName == "Remove")
        {
            stat -= Selected;
        }
        else
        {
            Console.WriteLine("Try again");
            AmountStat(stat, amount, statName);
        }
    }
}