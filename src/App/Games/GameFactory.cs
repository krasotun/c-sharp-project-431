namespace App.Games;

public static class GameFactory
{
    public static IGame CreateGame(GameType gameType)
    {
        return gameType switch
        {
            GameType.Even => new Even(),
            GameType.Calc => new Calc(),
            GameType.Gcd => new Gcd(),
            GameType.Progression => new Progression(),
            _ => throw new ArgumentOutOfRangeException(
                nameof(gameType),
                $"Unknown game: {gameType}"
            ),
        };
    }
}
