using Assets.Scripts.Game.Events;
using Assets.Scripts.Game.UseCase.Player;
using UnityEngine;

public class Rotate : IRotate
{
    public OnPlayerRotateEvent OnPlayerRotateEvent { get; set; } = new OnPlayerRotateEvent();
    private void notify(Vector3 rotation) { 
        
        OnPlayerRotateEvent?.Invoke(rotation);
    }

    public void PerformRotation(Rigidbody rb, Vector3 rotation, float rotationSpeed) {

        var rbYRotation = rb.rotation.eulerAngles.y + (rotation.x * rotationSpeed) * Time.fixedDeltaTime;

        rb.rotation = Quaternion.Euler(0.0f, rbYRotation, 0.0f);

        notify(rotation);
    }
}
