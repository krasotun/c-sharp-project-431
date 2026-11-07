namespace App.Games;

public static class Progression
{
    private const string Rules = "What number is missing in the progression?";
    private const int Length = 10;
    private const int MinStep = 1;
    private const int MaxStepExclusive = 11;
    private const string HiddenPlaceholder = "..";

    public static void Play()
    {
        var questions = new string[Engine.Rounds];
        var answers = new string[Engine.Rounds];

        for (var i = 0; i < Engine.Rounds; i++)
        {
            var start = RandomUtils.GetRandomInt();
            var step = RandomUtils.GetRandomInt(MinStep, MaxStepExclusive);
            var progression = GenerateProgression(start, step, Length);
            var hiddenIndex = RandomUtils.GetRandomInt(0, progression.Length);

            questions[i] = BuildQuestion(progression, hiddenIndex);
            answers[i] = progression[hiddenIndex].ToString();
        }

        Engine.Run(Rules, questions, answers);
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
