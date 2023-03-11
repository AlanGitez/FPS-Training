using Assets.Scripts.Game.Events;
using Assets.Scripts.Game.UseCase.Player;


public class Jump : IJump
{
    public OnPlayerJumpEvent OnPlayerJumpEvent { get; set; } = new OnPlayerJumpEvent();

    public void OnPlayerJump(float jumpPower) {

        OnPlayerJumpEvent?.Invoke(jumpPower);
    }


}
