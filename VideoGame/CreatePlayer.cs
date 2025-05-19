namespace VideoGame;

public class CreatePlayer
{
    public static void CreatePlayerUnit(string difficulty)
    {
        MyGame.Player = new Player();
        
        switch (MyGame.Difficulty)
        {
            case "Easy":
                PlayerStats.SetHealth(200, MyGame.Player);
                // PlayerStats.StatVariables(20, MyGame.Player);
                TestDocument.LvlUpBonus(MyGame.Player, 20);
                TestDocument.ShareStats(MyGame.Player);
                break;
            case "Medium":
                PlayerStats.SetHealth(150, MyGame.Player);
                // PlayerStats.LvlUpBonus(15, MyGame.Player);
                PlayerStats.StatVariables(MyGame.Player);
                break;
            case "Hard":
                PlayerStats.SetHealth(100, MyGame.Player);
                // PlayerStats.LvlUpBonus(10, MyGame.Player);
                PlayerStats.StatVariables(MyGame.Player);
                break;
            default:
                break;
        }
    }
}