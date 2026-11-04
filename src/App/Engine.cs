using App.Games;

namespace App;

public class Engine(IGame game, string playerName)
{
    private const int MaxRounds = 3;

    public void StartGame()
    {
        Console.WriteLine(game.Rules);
        var rounds = 0;

        while (rounds < MaxRounds)
        {
            var gameRound = game.CreateRound();

            Console.WriteLine($"Question: {gameRound.Question}");
            Console.Write("Your answer: ");

            var playerAnswer = Console.ReadLine() ?? "";

            var correctAnswer = gameRound.Answer;

            if (playerAnswer != correctAnswer)
            {
                ShowWrongAnswerMessage(playerAnswer, correctAnswer);
                return;
            }

            rounds++;

            ShowCorrectAnswerMessage();
        }

        ShowFinishMessage();
    }

    private void ShowWrongAnswerMessage(string playerAnswer, string correctAnswer)
    {
        Console.WriteLine(
            $"'{playerAnswer}' is wrong answer ;(. Correct answer was '{correctAnswer}'."
        );
        Console.WriteLine($"Let's try again, {playerName}!");
    }

    private void ShowCorrectAnswerMessage()
    {
        Console.WriteLine("Correct!");
    }

    private void ShowFinishMessage()
    {
        Console.WriteLine($"Congratulations, {playerName}!");
    }
}
