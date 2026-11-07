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
}
