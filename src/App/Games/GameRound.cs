namespace App.Games;

public class GameRound(string question, string answer)
{
    public string Question { get; } = question;
    public string Answer { get; } = answer;
}
