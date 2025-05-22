namespace VideoGame;

public class EnemyCombatController
{
    public void EnemyAction()
    {
        if (MyGame.EnemyStrongAttack) EnemyStrong();
        else{
            var action = MyGame.random.Next(0,3);
            switch (action)
            {
                case 0:
                    EnemyAttack();
                    break;
                case 1:
                    EnemyStrong();
                    break;
                case 2:
                    Console.WriteLine("Zzzzz");
                    break;
            }
        }
    }
    
    void EnemyAttack()
    {
        if (MyGame.DoingEvade)
        {
            int evade = MyGame.random.Next(1, 101);
            if (evade < MyGame.EvadeChance)
            {
                Console.WriteLine("You dodged");
                return;
            }
            else
            {
                Console.WriteLine("You failed to dodge");
            }
        }

        int block = 1;
        if (MyGame.DoingBlock) block = 2;
        int enemyAttack = MyGame.random.Next(MyGame.EnemyDamgeMin, MyGame.EnemyDamgeMax);
        MyGame.PlayerHP -= enemyAttack / block;
        Console.WriteLine($"You lost {enemyAttack} Hp");
        Console.WriteLine($"Enemy Attacked");
    }

    void EnemyStrong()
    {
        if (MyGame.EnemyStrongAttack)
        {
            if (MyGame.DoingEvade)
            {
                int evade = MyGame.random.Next(1, 101);
                if (evade < MyGame.EvadeChance)
                {
                    Console.WriteLine("You dodged");
                    return;
                }
                else
                {
                    Console.WriteLine("You failed to dodge");
                }
            }
        
            int block = 1;
            if (MyGame.DoingBlock) block = 2;
            int enemyAttack = MyGame.random.Next(MyGame.EnemyDamgeMin, MyGame.EnemyDamgeMax) * 3;
            MyGame.PlayerHP -= enemyAttack / block;
            Console.WriteLine($"Enemy Used Heavy");
            Console.WriteLine($"You lost {enemyAttack} Hp");
            MyGame.EnemyStrongAttack = false;
        }
        else
        {
            Console.WriteLine($"Enemy is getting stronger");
            MyGame.EnemyStrongAttack = true;
        }
    }
}