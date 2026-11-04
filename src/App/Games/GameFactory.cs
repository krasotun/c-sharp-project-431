public static class GameFactory
{
    public static IGame Factory(GameName gameName, string playerName)
    {
        return gameName switch
        {
            GameName.Even => new Even(playerName),
            _ => throw new ArgumentOutOfRangeException(
                nameof(gameName),
                $"Unknown game: {gameName}"
            ),
        };
    }
}
