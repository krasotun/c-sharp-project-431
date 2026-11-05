namespace App;

public static class RandomUtils
{
    private const int MinNumber = 1;
    private const int MaxNumberExclusive = 101;

    public static int GetRandomInt()
    {
        return Random.Shared.Next(MinNumber, MaxNumberExclusive);
    }

    public static T GetRandomElement<T>(T[] items)
    {
        return items[Random.Shared.Next(items.Length)];
    }
}
