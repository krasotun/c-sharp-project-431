namespace App.Games;

public class Prime : IGame
{
    private const int MinPrime = 2;

    public string Rules => "Answer 'yes' if given number is prime. Otherwise answer 'no'.";

    public GameRound CreateRound()
    {
        var number = RandomUtils.GetRandomInt();

        var correctAnswer = IsPrime(number) ? "yes" : "no";

        return new GameRound(number.ToString(), correctAnswer);
    }

    private static bool IsPrime(int number)
    {
        if (number < MinPrime)
        {
            return false;
        }

        for (var divisor = 2; divisor * divisor <= number; divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
