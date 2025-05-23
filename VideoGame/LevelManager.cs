namespace VideoGame;

public class LevelManager
{
    private int _extraExp = 0;
    
    
    public void EarnExp(int earnedExp, Player player)
    {
        player.Lvl.ExperienceNeeded -= earnedExp;
        if (player.Lvl.ExperienceNeeded <= 0)
        {
            if (player.Lvl.ExperienceNeeded < 0)
            {
                _extraExp = Math.Abs(player.Lvl.ExperienceNeeded);
            }
            player.Lvl.level += 1;
            player.Lvl.ExperienceNeeded = 100;
            player.Stat.StatPoints += 3;
            player.Stat.Strength += 1;
            player.Stat.Agility += 1;
            player.Stat.Health += 1;
            player.Lvl.ExperienceNeeded -= _extraExp;
        }
    }
}