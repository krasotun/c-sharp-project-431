using App.Games;

namespace App;

public static class Launcher
{
    public static void Start()
    {
        Console.WriteLine("Please enter the game number and press Enter.");
        Console.WriteLine("1 - Greet");
        Console.WriteLine("2 - Even");
        Console.WriteLine("3 - Calc");
        Console.WriteLine("4 - GCD");
        Console.WriteLine("5 - Progression");
        Console.WriteLine("6 - Prime");
        Console.WriteLine("0 - Exit");
        Console.Write("Your choice: ");

        var userChoice = Console.ReadLine();

        if (userChoice == "0")
        {
            return;
        }

        if (userChoice == "1")
        {
            Cli.MeetPlayer();
            return;
        }

        GameType? nullableGameType = userChoice switch
        {
            "2" => GameType.Even,
            "3" => GameType.Calc,
            "4" => GameType.Gcd,
            "5" => GameType.Progression,
            "6" => GameType.Prime,
            _ => null,
        };

        if (nullableGameType is not GameType gameType)
        {
            Console.WriteLine("Unsupported game, try another");
            return;
        }

        var game = GameFactory.CreateGame(gameType);
        var playerName = Cli.MeetPlayer();
        var engine = new Engine(game, playerName);

        engine.StartGame();
    }
}
