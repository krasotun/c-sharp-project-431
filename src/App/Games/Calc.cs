namespace App.Games;

public class Calc : IGame
{
    private static readonly char[] Operators = ['+', '-', '*'];
    public string Rules => "What is the result of the expression?";

    public GameRound CreateRound()
    {
        var left = RandomUtils.GetRandomInt();
        var right = RandomUtils.GetRandomInt();
        var op = RandomUtils.GetRandomElement(Operators);
        var answer = GetAnswer(left, right, op);

        return new GameRound($"{left} {op} {right}", answer.ToString());
    }

    private static int GetAnswer(int left, int right, char op)
    {
        return op switch
        {
            '+' => left + right,
            '-' => left - right,
            '*' => left * right,
            _ => throw new ArgumentOutOfRangeException(nameof(op), $"Unknown operator: {op}"),
        };
    }
}
