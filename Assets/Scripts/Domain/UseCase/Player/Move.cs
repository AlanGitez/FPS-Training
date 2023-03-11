using Assets.Scripts.Game.Events;
using Assets.Scripts.Game.UseCase.Player;

public class Move : IMove
{
    public OnPlayerMoveEvent OnPlayerMoveEvent { get; set; } = new OnPlayerMoveEvent();
}
