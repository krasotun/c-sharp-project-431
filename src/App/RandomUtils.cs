namespace App;

public static class RandomUtils
{
    private const int MinNumber = 1;
    private const int MaxNumberExclusive = 101;

    public static int GetRandomInt()
    {
        return GetRandomInt(MinNumber, MaxNumberExclusive);
    }

    public static int GetRandomInt(int min, int maxExclusive)
    {
        return Random.Shared.Next(min, maxExclusive);
    }

    public static T GetRandomElement<T>(T[] items)
    {
        return items[GetRandomIndex(items)];
    }

    public static int GetRandomIndex<T>(T[] items)
    {
        return GetRandomInt(0, items.Length);
    }
}
