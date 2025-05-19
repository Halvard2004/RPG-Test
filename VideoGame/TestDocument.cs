namespace VideoGame;

public class TestDocument
{
    private static int _strengthGive = 0;
    private static int _healthGive = 0;
    private static int _agilityGive = 0;


    public static void LvlUpBonus(Player unit, int amount = 2)
    {
        unit.Stat.StatPoints += amount;
    }
    
    public static void SetHealth(int amount, Player unit)
    {
        unit.MaxHealth = amount;
        unit.Health =  unit.MaxHealth;
    }
    
    public static void ShareStats(Player unit)
    {
        while (true){
        Console.WriteLine($"Stat Points to give: {unit.Stat.StatPoints}");
        Console.WriteLine($"Strength: {Stats.Strength} + {_strengthGive}");
        Console.WriteLine($"Agility: {Stats.Agility} + {_agilityGive}");
        Console.WriteLine($"Health: {Stats.Health} + {_healthGive}");
        _strengthGive++;
        _healthGive++;
        _agilityGive++;
        // if (unit.Stat.StatPoints <= 0)
        // {
        // }
        DecideStat(unit);
        return;
        }


    }

    public static void DecideStat(Player unit)
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
            SelectGiveTakeStat(_strengthGive, unit);
            return;
        } 
        else if (input.Key == ConsoleKey.D2)
        {
            SelectGiveTakeStat(_agilityGive, unit);
            return;
        } 
        else if (input.Key == ConsoleKey.D3)
        {
            SelectGiveTakeStat(_healthGive, unit);
            return;
        }
        else;
        {
            DecideStat(unit);
        }
    }

    public static void SelectGiveTakeStat(int stat, Player unit)
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
                AmountStat(stat, "Remove", unit);
                break;
            case ConsoleKey.D2:
                AmountStat(stat,  "Add", unit);
                break;
            default:
                SelectGiveTakeStat(stat, unit);
                return;
        }
        
    }

    public static void AmountStat(int stat, string statName, Player unit)
    {
        int Selected;
        Console.WriteLine($"""
                           How much
                           1) 1
                           2) 5
                           3) {unit.Stat.StatPoints}
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
                Selected = unit.Stat.StatPoints;
                break;
            default:
                AmountStat(stat, statName, unit);
                return;
        }

        switch (statName)
        {
            case "Add":
                stat += Selected;
                break;
            case "Remove":
                stat -= Selected;
                break;
            default:
                Console.WriteLine("Try again");
                AmountStat(stat, statName, unit);
                break;
        }
        
        
        
    }
}