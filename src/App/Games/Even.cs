namespace App.Games;

public class Even : IGame
{
    public string Rules => "Answer 'yes' if the number is even, otherwise answer 'no'";

    public GameRound CreateRound()
    {
        int number = RandomUtils.GetRandomInt();

        var correctAnswer = IsEven(number) ? "yes" : "no";

        return new GameRound(number.ToString(), correctAnswer);
    }

    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
