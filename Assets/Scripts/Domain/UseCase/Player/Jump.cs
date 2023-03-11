using Assets.Scripts.Game.Events;
using Assets.Scripts.Game.UseCase.Player;
using UnityEngine;

public class Jump : IJump
{
    public OnPlayerJumpEvent OnPlayerJumpEvent { get; set; } = new OnPlayerJumpEvent();

    private void notify(float jumpPower) {

        OnPlayerJumpEvent?.Invoke(jumpPower);
    }

    public void PerformJump(Rigidbody rb, float jumpPower, out bool isJump) {

        var jumpVector = new Vector3(0.0f, rb.position.y * jumpPower, 0.0f);

        rb.AddRelativeForce(jumpVector, ForceMode.Impulse);

        isJump = true;
        notify(jumpPower);
    }

}
