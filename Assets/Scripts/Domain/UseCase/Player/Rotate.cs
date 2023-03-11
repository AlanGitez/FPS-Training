using Assets.Scripts.Game.Events;
using Assets.Scripts.Game.UseCase.Player;

public class Rotate : IRotate
{
    public OnPlayerRotateEvent OnPlayerRotateEvent { get; set; } = new OnPlayerRotateEvent();

}
