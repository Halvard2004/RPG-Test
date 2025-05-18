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
                PlayerStats.StatVariables(20);
                break;
            case "Medium":
                PlayerStats.SetHealth(150, MyGame.Player);
                PlayerStats.StatVariables(15);
                break;
            case "Hard":
                PlayerStats.SetHealth(100, MyGame.Player);
                PlayerStats.StatVariables(10);
                break;
            default:
                break;
        }
    }
}