App.Start();

public static class App
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
                var even = GameFactory.Factory(GameName.Even, playerName);
                even.Start();
                break;

            default:
                break;
        }
    }
}
