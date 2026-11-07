namespace App.Games;

public static class Gcd
{
    private const string Rules = "Find the greatest common divisor of given numbers.";
    private const int MinDivisor = 1;

    public static void Play()
    {
        var questions = new string[Engine.Rounds];
        var answers = new string[Engine.Rounds];

        for (var i = 0; i < Engine.Rounds; i++)
        {
            var first = RandomUtils.GetRandomInt();
            var second = RandomUtils.GetRandomInt();

            questions[i] = $"{first} {second}";
            answers[i] = FindGcd(first, second).ToString();
        }

        Engine.Run(Rules, questions, answers);
    }

    private static int FindGcd(int a, int b)
    {
        var min = a < b ? a : b;

        for (var divisor = min; divisor > MinDivisor; divisor--)
        {
            if (a % divisor == 0 && b % divisor == 0)
            {
                return divisor;
            }
        }

        return MinDivisor;
    }
}
