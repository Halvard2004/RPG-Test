namespace VideoGame;

public class MyGame
{
    public static Player Player;
    public static string Difficulty = "";
    public static bool EnemyStrongAttack = false;
    public static bool DoingBlock = false;
    public static bool DoingEvade = false;
    public static int Duels = 0;
    public static int Lvl = 1;
    public static int ExperienceNeed = 50;
    public static int PlayerHP;
    public static int PlayerHPMax;
    public static int EnemyHp;
    public static int EnemyHpMax;
    public static int EnemyHpMin;
    public static int PlayerDamageMax;
    public static int PlayerDamageMin;
    public static int EnemyDamgeMax;
    public static int EnemyDamgeMin;
    public static int EvadeChance = 33;
    public static Random random = new Random();


    public static void Run()
    {
        StartGame();
        // Tutorial.FirstFightPhaseOne();
    }

    static void StartGame()
    {
        SelectDifficulty();
        CreatePlayer();
    }

    static void SelectDifficulty()
    {
        Console.WriteLine("""
                          Hello Adventurer,
                          Which difficulty do you want to play?
                          1) Easy
                          2) Medium
                          3) Hard 
                          """
        );
        ConsoleKeyInfo input = Console.ReadKey(true);
        if (input.Key == ConsoleKey.D1)
        {
            Difficulty = "Easy";
            Console.Clear();
            return;
        } 
        else if (input.Key == ConsoleKey.D2)
        {
            Difficulty = "Medium";
            Console.Clear();
            return;
        } 
        else if (input.Key == ConsoleKey.D3)
        {
            Difficulty = "Hard";
            Console.Clear();
            return;
        }
        else;
        {
            Console.Clear();
            Console.WriteLine("Invalid key pressed, please try again.");
            SelectDifficulty();
        }
    }

    public static void CreatePlayer()
    {
        Player = new Player();
    }


    // public static void CreateEnemy()
    // {
    //     EnemyHp = random.Next(EnemyHpMin, EnemyHpMax);
    //     Duels++;
    // }
    //
    //
    // static void Evade()
    // {
    //     DoingEvade  = true;
    // }
    //
    //
    //
    // static void Recover()
    // {
    //     int PlayerHealing = random.Next(0, PlayerHPMax / 4);
    //     PlayerHP += PlayerHealing;
    //     if (PlayerHP > PlayerHPMax)
    //     {
    //         PlayerHP = PlayerHPMax;
    //     }
    // }
    //
    //
    // public static void Fight()
    // {
    //     while (true)
    //     {
    //       SelectAction();
    //       Console.Clear();
    //       if (CheckHp()) break;
    //       EnemyMoveSet.EnemyAction(); 
    //       if (CheckHp()) break;
    //       Console.WriteLine($"PlayerHP: {PlayerHP}       EnemyHp: {EnemyHp}");
    //     }
    //     
    //     if (EnemyHp <= 0)
    //     {
    //         Console.WriteLine("You Win");
    //     }
    //     if (PlayerHP <= 0)
    //     {
    //         Console.WriteLine("You Lose");
    //     }
    //     
    // }
    //
    // static void SelectAction()
    // {
    //     DoingEvade = false;
    //     DoingBlock = false;
    //     Console.WriteLine("""
    //                       1) Attack
    //                       2) Recover
    //                       3) Evade
    //                       4) Block 
    //                       """
    //     );
    //     ConsoleKeyInfo input = Console.ReadKey();
    //     switch (input.Key)
    //     {
    //         case ConsoleKey.D1:
    //             Attack();
    //             break;
    //         case ConsoleKey.D2:
    //             Recover();
    //             break;
    //         case ConsoleKey.D3:
    //             Evade();
    //             break;
    //         case ConsoleKey.D4:
    //             Block();
    //             break;
    //         default:
    //             Console.WriteLine("Invalid key pressed, please try again.");
    //             SelectAction();
    //             break;
    //     }
    // }
    //
    // static void Attack()
    // {
    //     int playerAttack = random.Next(PlayerDamageMin, PlayerDamageMax);
    //     EnemyHp -= playerAttack;
    //     Console.WriteLine($"You took {playerAttack} Hp");
    // }
    //
    // static void Block()
    // {
    //     DoingBlock = true;
    // }
    // public static bool CheckHp()
    // {
    //     if(EnemyHp <= 0 || PlayerHP <= 0) return true;
    //     return false;
    // }
}