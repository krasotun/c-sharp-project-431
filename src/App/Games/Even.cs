namespace App.Games;

public static class Even
{
    private const string Rules = "Answer 'yes' if the number is even, otherwise answer 'no'.";

    public static void Play()
    {
        var questions = new string[Engine.Rounds];
        var answers = new string[Engine.Rounds];

        for (var i = 0; i < Engine.Rounds; i++)
        {
            var number = RandomUtils.GetRandomInt();
            var question = number.ToString();

            var answer = IsEven(number) ? "yes" : "no";

            questions[i] = question;
            answers[i] = answer;
        }

        Engine.Run(Rules, questions, answers);
    }

    private static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
