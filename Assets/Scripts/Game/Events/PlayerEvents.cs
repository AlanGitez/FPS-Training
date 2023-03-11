using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts.Game.Events
{
    [System.Serializable]
    public class OnPlayerMoveEvent : UnityEvent<Vector2> { }

    [System.Serializable]
    public class OnPlayerJumpEvent : UnityEvent<float> { }

    [System.Serializable]
    public class OnPlayerRotateEvent : UnityEvent<Vector3> { }
}