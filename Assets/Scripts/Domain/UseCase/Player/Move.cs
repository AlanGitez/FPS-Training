using Assets.Scripts.Game.Events;
using Assets.Scripts.Game.UseCase.Player;
using UnityEngine;

public class Move : IMove
{
    public OnPlayerMoveEvent OnPlayerMoveEvent { get; set; } = new OnPlayerMoveEvent();

    private void notify(Vector2 moveDirection)
    {
        OnPlayerMoveEvent?.Invoke(moveDirection);
    }

    public void PerformMovement(Rigidbody rb, Vector2 moveDirection, float movementSpeed) {
      
        Vector3 newPosition = new Vector3(moveDirection.x, 0.0f, moveDirection.y);

        var rbPosition = new Vector3(
            newPosition.x * movementSpeed,
            newPosition.y,
            newPosition.z * movementSpeed);


        rb.AddRelativeForce(rbPosition, ForceMode.Force);

        notify(moveDirection);

    }

}
