namespace VideoGame;

public class PlayerCreator
{
    public Player CreatePlayerUnit(string difficulty)
    {
        Player player = new Player();
        PlayerStatsManager playerStatsManager = new PlayerStatsManager();
        switch (difficulty)
        {
            case "Easy":
                playerStatsManager.SetHealth(200, player);
                playerStatsManager.LvlUpBonus(player, 20);
                playerStatsManager.EditStatsMenu(player);
                break;
            case "Medium":
                playerStatsManager.SetHealth(150, player);
                playerStatsManager.LvlUpBonus(player, 15);
                playerStatsManager.EditStatsMenu(player);
                break;
            case "Hard":
                playerStatsManager.SetHealth(100, player);
                playerStatsManager.LvlUpBonus(player, 10);
                playerStatsManager.EditStatsMenu(player);
                break;
            default:
                break;
        }
        return player;
    }
}