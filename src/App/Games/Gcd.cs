namespace App.Games;

public class Gcd : IGame
{
    public string Rules => "Find the greatest common divisor of given numbers.";

    public GameRound CreateRound()
    {
        var first = RandomUtils.GetRandomInt();
        var second = RandomUtils.GetRandomInt();
        var answer = FindGcd(first, second);

        return new GameRound($"{first} {second}", answer.ToString());
    }

    private static int FindGcd(int a, int b)
    {
        int min = a < b ? a : b;

        for (int i = min; i >= 1; i--)
        {
            if (a % i == 0 && b % i == 0)
            {
                return i;
            }
        }

        return 1;
    }
}
