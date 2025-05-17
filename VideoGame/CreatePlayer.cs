namespace VideoGame;

public class CreatePlayer
{
    public static void CreatePlayerUnit(string difficulty)
    {
        MyGame.Player = new Player();
        
        switch (MyGame.Difficulty)
        {
            case "Easy":
                PlayerStats.GiveHealth(200);
                PlayerStats.StatVariables(20);
                break;
            case "Medium":
                PlayerStats.GiveHealth(150);
                PlayerStats.StatVariables(15);
                break;
            case "Hard":
                PlayerStats.GiveHealth(100);
                PlayerStats.StatVariables(10);
                break;
            default:
                break;
        }
    }
}