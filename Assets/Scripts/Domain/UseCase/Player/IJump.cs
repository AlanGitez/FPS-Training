using Assets.Scripts.Game.Events;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game.UseCase.Player
{
    public interface IJump
    {

        OnPlayerJumpEvent OnPlayerJumpEvent { get; }
        void OnPlayerJump(float jumpPower);
    }
}