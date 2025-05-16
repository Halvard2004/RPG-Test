namespace VideoGame;

public class Tutorial
{
    //  public static void FirstFightPhaseOne()
    // {
    //     MyGame.CreateEnemy();
    //     Console.WriteLine("This is the Tutorial");
    //     Console.WriteLine("First lets learn how to attack");
    //     Console.ReadKey();
    //     Console.Clear();
    //     FirstFightPhaseTwo();
    //     FirstFightPhaseThree();
    //     FirstFightPhaseFour();
    //     FirstFightPhaseSix();
    //     MyGame.Fight();
    //
    // }
    //
    // static void FirstFightPhaseTwo()
    // {
    //     Console.WriteLine($"PlayerHP: {MyGame.PlayerHP}       EnemyHp: {MyGame.EnemyHp}");
    //     Console.WriteLine("Press 1) to attack "); 
    //     ConsoleKeyInfo input = Console.ReadKey();
    //     if (input.Key == ConsoleKey.D1)
    //     {
    //         Console.Clear();
    //         DoDamageTutorial();
    //     }
    //     else
    //     {
    //         Console.Clear();
    //         Console.WriteLine("Invalid key pressed, please try again.");
    //         FirstFightPhaseTwo();
    //     }
    // }
    //
    //  static void DoDamageTutorial()
    // {
    //     int playerAttack = MyGame.random.Next(MyGame.PlayerDamageMin, MyGame.PlayerDamageMax);
    //     MyGame.EnemyHp -= playerAttack;
    //     Console.WriteLine("You did it");
    //     Console.WriteLine($"You took {playerAttack} Hp");
    //     Console.WriteLine($"PlayerHP: {MyGame.PlayerHP}       EnemyHp: {MyGame.EnemyHp}");
    //     Console.WriteLine("Now it is angry, be careful");
    //     Console.ReadKey();
    //     Console.Clear();
    //     
    //     
    // }
    //
    // static void FirstFightPhaseThree()
    // {
    //     int enemyAttack = MyGame.random.Next(MyGame.EnemyDamgeMin, MyGame.EnemyDamgeMax);
    //     MyGame.PlayerHP -= enemyAttack;
    //     Console.WriteLine($"You lost {enemyAttack} Hp");
    //     Console.WriteLine($"PlayerHP: {MyGame.PlayerHP}       EnemyHp: {MyGame.EnemyHp}");
    //     Console.WriteLine("Lets try to recover some of that back");
    // }
    //
    // static void FirstFightPhaseFour()
    // {
    //     Console.WriteLine("Press 2) to recover");
    //     ConsoleKeyInfo input = Console.ReadKey();
    //     if (input.Key == ConsoleKey.D2)
    //     {
    //         Console.Clear();
    //         RecoverTutorial();
    //     }
    //     else
    //     {
    //         Console.Clear();
    //         FirstFightPhaseFour();
    //     }
    // }
    //
    // static void RecoverTutorial()
    // {
    //     int PlayerHealing = MyGame.PlayerHPMax - MyGame.PlayerHP;
    //     MyGame.PlayerHP += PlayerHealing;
    //     Console.WriteLine("This can heal you up to 1/4 of your HP");
    //     Console.WriteLine($"You healed {PlayerHealing} HP");
    //     Console.WriteLine("""
    //                       The enemy did not like that you recovered your HP
    //                       It seems it will use a STRONG attack, this takes 2 turns to use,
    //                       but the damage will be 3x Normal.
    //                       What you can do is either Evade or Block
    //                       Evade: You have a 33% of dodging the attack
    //                       Block: You will block the attack and only take 50% of damage
    //                       """);
    //     Console.ReadKey();
    //     Console.Clear();
    //     FirstFightPhaseFive();
    //
    // }
    //
    // static void FirstFightPhaseFive()
    // {
    //     Console.WriteLine("""
    //                       Press 3) To Evade
    //                       Press 4) To Block
    //                       """);
    //     ConsoleKeyInfo input = Console.ReadKey();
    //     if (input.Key == ConsoleKey.D3)
    //     {
    //         Console.Clear();
    //         EvadeTutorial();
    //     } else if (input.Key == ConsoleKey.D4)
    //     {
    //         Console.Clear();
    //         BlockTutorial();
    //     }
    //     else
    //     {
    //         FirstFightPhaseFive();
    //     }
    //     
    // }
    //
    // static void EvadeTutorial()
    // {
    //         Console.WriteLine("You dodged its attack");
    //         Console.WriteLine($"PlayerHP: {MyGame.PlayerHP}       EnemyHp: {MyGame.EnemyHp}");
    // }
    //
    // static void BlockTutorial()
    // {
    //     int enemyAttack = (MyGame.random.Next(MyGame.EnemyDamgeMin, MyGame.EnemyDamgeMax) * 3) / 2;
    //     MyGame.PlayerHP -= enemyAttack;
    //     Console.WriteLine($"You lost {enemyAttack} Hp");
    // }
    //
    // static void FirstFightPhaseSix()
    // {
    //     Console.WriteLine("You are now done with the basics, i will tell you what to do after you have defeated the enemy Good Luck");
    //     Console.WriteLine("PS: Let me heal you up before you start fighting");
    //     MyGame.PlayerHP = MyGame.PlayerHPMax;
    //     Console.ReadKey();
    //     Console.Clear();
    //
    // }
}