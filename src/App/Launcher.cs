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

        switch (userChoice)
        {
            case "0":
                break;
            case "1":
                Cli.MeetPlayer();
                break;
            case "2":
                Even.Play();
                break;
            case "3":
                Calc.Play();
                break;
            case "4":
                Gcd.Play();
                break;
            case "5":
                Progression.Play();
                break;
            case "6":
                Prime.Play();
                break;
            default:
                Console.WriteLine("Unsupported game, try another");
                break;
        }
    }
}
