namespace App;

public static class Cli
{
    public static string GreetPlayer()
    {
        Console.WriteLine("Welcome to the Brain Games!");
        Console.Write("May I have your name? ");

        var playerName = Console.ReadLine();
        Console.WriteLine($"Hello, {playerName}!");

        return playerName ?? "";
    }
}
