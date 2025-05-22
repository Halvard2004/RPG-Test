namespace VideoGame;

public class LevelManager
{
    private int _extraExp;
    
    
    public void EarnExp(int earnedExp)
    {
        MyGame.Player.Lvl.ExperienceNeeded -= earnedExp;
        if (MyGame.Player.Lvl.ExperienceNeeded <= 0)
        {
            if (MyGame.Player.Lvl.ExperienceNeeded < 0)
            {
                _extraExp = Math.Abs(MyGame.Player.Lvl.ExperienceNeeded);
            }
            MyGame.Player.Lvl.level += 1;
            MyGame.Player.Lvl.ExperienceNeeded = 100;
            MyGame.Player.Stat.StatPoints += 3;
        }
    }
}