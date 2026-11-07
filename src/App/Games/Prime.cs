namespace App.Games;

public static class Prime
{
    private const string Rules = "Answer 'yes' if given number is prime. Otherwise answer 'no'.";
    private const int MinPrime = 2;

    public static void Play()
    {
        var questions = new string[Engine.Rounds];
        var answers = new string[Engine.Rounds];

        for (var i = 0; i < Engine.Rounds; i++)
        {
            var number = RandomUtils.GetRandomInt();

            questions[i] = number.ToString();
            answers[i] = IsPrime(number) ? "yes" : "no";
        }

        Engine.Run(Rules, questions, answers);
    }

    private static bool IsPrime(int number)
    {
        if (number < MinPrime)
        {
            return false;
        }

        for (var divisor = MinPrime; divisor * divisor <= number; divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
