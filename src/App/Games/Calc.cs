namespace App.Games;

public static class Calc
{
    private const string Rules = "What is the result of the expression?";
    private static readonly char[] Operators = ['+', '-', '*'];

    public static void Play()
    {
        var questions = new string[Engine.Rounds];
        var answers = new string[Engine.Rounds];

        for (var i = 0; i < Engine.Rounds; i++)
        {
            var left = RandomUtils.GetRandomInt();
            var right = RandomUtils.GetRandomInt();
            var op = Operators[RandomUtils.GetRandomInt(0, Operators.Length)];

            questions[i] = $"{left} {op} {right}";
            answers[i] = Calculate(left, right, op).ToString();
        }

        Engine.Run(Rules, questions, answers);
    }

    private static int Calculate(int left, int right, char op)
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
