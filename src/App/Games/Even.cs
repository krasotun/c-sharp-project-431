public class Even(string playerName) : IGame
{
    private readonly string _playerName = playerName;
    private const int MaxRounds = 3;
    private const int MinNumber = 1;
    private const int MaxNumberExclusive = 101;

    public void Start()
    {
        Console.WriteLine("Answer 'yes' if the number is even, otherwise answer 'no'");
        var steps = 0;

        while (steps < MaxRounds)
        {
            int number = Random.Shared.Next(MinNumber, MaxNumberExclusive);
            Console.WriteLine($"Question: {number}");
            Console.Write("Your answer: ");

            var playerAnswer = Console.ReadLine() ?? "";

            var correctAnswer = IsEven(number) ? "yes" : "no";

            if (playerAnswer != correctAnswer)
            {
                ShowWrongAnswerMessage(playerAnswer, correctAnswer);
                return;
            }

            steps++;

            ShowCorrectAnswerMessage();
        }

        ShowFinishMessage();
    }

    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    private void ShowWrongAnswerMessage(string playerAnswer, string correctAnswer)
    {
        Console.WriteLine(
            $"'{playerAnswer}' is wrong answer ;(. Correct answer was '{correctAnswer}'."
        );
        Console.WriteLine($"Let's try again, {_playerName}!");
    }

    private void ShowCorrectAnswerMessage()
    {
        Console.WriteLine("Correct!");
    }

    private void ShowFinishMessage()
    {
        Console.WriteLine($"Congratulations, {_playerName}!");
    }
}
