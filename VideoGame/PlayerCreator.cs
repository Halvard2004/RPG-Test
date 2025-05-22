namespace VideoGame;

public class PlayerCreator
{
    public void CreatePlayerUnit(string difficulty)
    {
        MyGame.Player = new Player();
        
        switch (difficulty)
        {
            case "Easy":
                PlayerStatsManager.SetHealth(200, MyGame.Player);
                PlayerStatsManager.LvlUpBonus(MyGame.Player, 20);
                PlayerStatsManager.EditStatsMenu(MyGame.Player);
                break;
            case "Medium":
                PlayerStatsManager.SetHealth(150, MyGame.Player);
                PlayerStatsManager.LvlUpBonus(MyGame.Player, 15);
                PlayerStatsManager.EditStatsMenu(MyGame.Player);
                break;
            case "Hard":
                PlayerStatsManager.SetHealth(100, MyGame.Player);
                PlayerStatsManager.LvlUpBonus(MyGame.Player, 10);
                PlayerStatsManager.EditStatsMenu(MyGame.Player);
                break;
            default:
                break;
        }
    }
}