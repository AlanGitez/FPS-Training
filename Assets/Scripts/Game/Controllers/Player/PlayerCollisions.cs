using Assets.Scripts.Game.Controllers.Player;
using Assets.Scripts.Game.UseCase.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private ICollisionListener collisionListener;

    public void SetCollisionListener(ICollisionListener listener)
    {
        collisionListener = listener;

    }
    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Ground") collisionListener.OnCollide();

    }
}
