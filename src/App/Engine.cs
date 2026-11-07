namespace App;

public static class Engine
{
    public const int Rounds = 3;

    public static void Run(string rules, string[] questions, string[] answers)
    {
        var playerName = Cli.MeetPlayer();

        Console.WriteLine(rules);

        for (var i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Question: {questions[i]}");
            Console.Write("Your answer: ");

            var playerAnswer = Console.ReadLine() ?? "";
            var correctAnswer = answers[i];

            if (playerAnswer != correctAnswer)
            {
                ShowWrongAnswerMessage(playerAnswer, correctAnswer, playerName);
                return;
            }

            ShowCorrectAnswerMessage();
        }

        ShowFinishMessage(playerName);
    }

    private static void ShowWrongAnswerMessage(
        string playerAnswer,
        string correctAnswer,
        string playerName
    )
    {
        Console.WriteLine(
            $"'{playerAnswer}' is wrong answer ;(. Correct answer was '{correctAnswer}'."
        );
        Console.WriteLine($"Let's try again, {playerName}!");
    }

    private static void ShowCorrectAnswerMessage()
    {
        Console.WriteLine("Correct!");
    }

    private static void ShowFinishMessage(string playerName)
    {
        Console.WriteLine($"Congratulations, {playerName}!");
    }
}
