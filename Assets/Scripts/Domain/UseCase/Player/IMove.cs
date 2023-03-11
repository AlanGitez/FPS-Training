using Assets.Scripts.Game.Events;

namespace Assets.Scripts.Game.UseCase.Player
{
    public interface IMove
    {
        
        OnPlayerMoveEvent OnPlayerMoveEvent { get; }
    }
}