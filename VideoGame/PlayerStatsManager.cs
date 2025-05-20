namespace VideoGame;

public class PlayerStatsManager
{
    private static int _strengthGive = 0;
    private static int _healthGive = 0;
    private static int _agilityGive = 0;
    private static int _tempStatPoints = 0;

    public static void LvlUpBonus(Player unit, int amount = 2)
    {
        unit.Stat.StatPoints += amount;
    }
    
    public static void SetHealth(int amount, Player unit)
    {
        unit.MaxHealth = amount;
        unit.Health =  unit.MaxHealth;
    }
    
    public static void EditStatsMenu(Player unit)
    {
        _tempStatPoints = unit.Stat.StatPoints;
        while (true){
            Console.WriteLine($"Stat Points to give: {_tempStatPoints}");
            Console.WriteLine($"Strength: {unit.Stat.Strength} + {_strengthGive}");
            Console.WriteLine($"Agility: {unit.Stat.Agility} + {_agilityGive}");
            Console.WriteLine($"Health: {unit.Stat.Health} + {_healthGive}");
            Console.WriteLine($"-----------------------------------------------");
            Console.WriteLine("""
                              What do you want to do?
                              1) Change stats
                              2) Save
                              3) Cancel
                              """
            );
            ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    EditStats(unit);
                    break;
                case ConsoleKey.D2:
                    SaveStatChange(unit);
                    return;
                case ConsoleKey.D3:
                    return;
            }
        
            // return;
        }


    }

    private static void EditStats(Player unit)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("""
                              Do you want to Add or Remove?
                              1) Add
                              2) Cancel
                              """);
            ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.D2:
                    EditStatsMenu(unit);
                    break;
                case ConsoleKey.D1:
                {
                    int selectedStat = DecideStat();
                    if (selectedStat == 0)
                    {
                        return;
                    }

                    int amount = DecideAmount(unit);
                    if (amount == 0)
                    {
                        return;
                    }

                    ChangeGiveStat(selectedStat, amount);
                    break;
                }
                default:
                    Console.WriteLine("Wrong input, try again");
                    continue;
            }

            break;
        }
    }


    private static int DecideStat()
    {
        while (true)
        {
            Console.WriteLine("""
                              Which stat do you want to give
                              1) Strength
                              2) Agility
                              3) Health
                              4) Cancel Option
                              """);
            ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    return (int)PlayerStatManagerStatGives.Strength;
                case ConsoleKey.D2:
                    return (int)PlayerStatManagerStatGives.Agility;
                case ConsoleKey.D3:
                    return (int)PlayerStatManagerStatGives.Health;
                case ConsoleKey.D4:
                    return 0;
                default:
                    ;
                    break;
            }

            {
            }
        }
    }

    private static int DecideAmount(Player unit)
    {
        while (true)
        {
            Console.WriteLine($"""
                               How much
                               1) 1
                               2) 5
                               3) {_tempStatPoints}
                               4) Cancel
                               """);
            ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.D1 when _tempStatPoints >= 1:
                    return 1;
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write($"You dont have enough Stat points: {_tempStatPoints}");
                    return DecideAmount(unit);
                case ConsoleKey.D2 when _tempStatPoints >= 5:
                    return 5;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write($"You dont have enough Stat points: {_tempStatPoints}");
                    return DecideAmount(unit);
                case ConsoleKey.D3 when _tempStatPoints > 0:
                    return _tempStatPoints;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.Write($"You have 0 Stat points: {_tempStatPoints}");
                    return DecideAmount(unit);
                case ConsoleKey.D4:
                    return 0;
                default:
                    return 0;
                    break;
            }
            
        }
    }

    private static void ChangeGiveStat(int statSelected, int amountToChange)
    {
        
        switch (statSelected)
        {
            case (int)PlayerStatManagerStatGives.Strength:
                _strengthGive += amountToChange;
                _tempStatPoints -= amountToChange;
                break;
            case (int)PlayerStatManagerStatGives.Agility:
                _agilityGive += amountToChange;
                _tempStatPoints -= amountToChange;
                break;
            case (int)PlayerStatManagerStatGives.Health:
                _healthGive += amountToChange;
                _tempStatPoints -= amountToChange;
                break;
        }
        }

    private static void SaveStatChange(Player unit)
    {
        unit.Stat.StatPoints = _tempStatPoints;
        unit.Stat.Strength += _strengthGive;
        unit.Stat.Agility += _agilityGive;
        unit.Stat.Health += _healthGive;
    }
}
    