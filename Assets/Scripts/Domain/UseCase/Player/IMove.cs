using Assets.Scripts.Game.Events;
using UnityEngine;

namespace Assets.Scripts.Game.UseCase.Player
{
    public interface IMove
    {
        OnPlayerMoveEvent OnPlayerMoveEvent { get; }
        void PerformMovement(Rigidbody rb, Vector2 moveDirection, float movementSpeed);

    }
}