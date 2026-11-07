namespace App.Games;

public class Progression : IGame
{
    private const int Length = 10;
    private const int MinStep = 1;
    private const int MaxStepExclusive = 11;
    private const string HiddenPlaceholder = "..";

    public string Rules => "What number is missing in the progression?";

    public GameRound CreateRound()
    {
        var start = RandomUtils.GetRandomInt();
        var step = RandomUtils.GetRandomInt(MinStep, MaxStepExclusive);
        var progression = GenerateProgression(start, step, Length);
        var hiddenIndex = RandomUtils.GetRandomIndex(progression);

        var question = BuildQuestion(progression, hiddenIndex);
        var answer = progression[hiddenIndex].ToString();

        return new GameRound(question, answer);
    }

    private static int[] GenerateProgression(int start, int step, int length)
    {
        var progression = new int[length];

        for (var index = 0; index < length; index++)
        {
            progression[index] = start + index * step;
        }

        return progression;
    }

    private static string BuildQuestion(int[] progression, int hiddenIndex)
    {
        var items = new string[progression.Length];

        for (var index = 0; index < progression.Length; index++)
        {
            items[index] = progression[index].ToString();
        }

        items[hiddenIndex] = HiddenPlaceholder;

        return string.Join(" ", items);
    }
}
