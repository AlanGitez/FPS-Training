using Assets.Scripts.Game.Events;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game.UseCase.Player
{
    public interface IJump
    {

        OnPlayerJumpEvent OnPlayerJumpEvent { get; }
        void PerformJump(Rigidbody rb, float jumpPower, out bool isJump);
    }
}