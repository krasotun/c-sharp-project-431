namespace App.Games;

public class Even : IGame
{
    public string Rules => "Answer 'yes' if the number is even, otherwise answer 'no'";
    private const int MinNumber = 1;
    private const int MaxNumberExclusive = 101;

    public GameRound CreateRound()
    {
        int number = Random.Shared.Next(MinNumber, MaxNumberExclusive);

        var correctAnswer = IsEven(number) ? "yes" : "no";

        return new GameRound(number.ToString(), correctAnswer);
    }

    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
