using Assets.Scripts.Game.Events;
using UnityEngine;

namespace Assets.Scripts.Game.UseCase.Player
{
    public interface IRotate
    { 
        OnPlayerRotateEvent OnPlayerRotateEvent { get; }
        void PerformRotation(Rigidbody rb, Vector3 rotation, float rotationSpeed);
    }
}