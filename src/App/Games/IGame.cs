namespace App.Games;

public interface IGame
{
    string Rules { get; }
    GameRound CreateRound();
}
