using App.Games;

namespace App;

public static class Launcher
{
    public static void Start()
    {
        Console.WriteLine("Please enter the game number and press Enter.");
        Console.WriteLine("1 - Greet");
        Console.WriteLine("2 - Even");
        Console.WriteLine("0 - Exit");
        Console.Write("Your choice: ");

        var userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                Cli.GreetPlayer();
                break;

            case "2":
                var playerName = Cli.GreetPlayer();
                var evenGame = GameFactory.CreateGame(GameType.Even);
                var engine = new Engine(evenGame, playerName);

                engine.StartGame();

                break;

            default:
                break;
        }
    }
}
