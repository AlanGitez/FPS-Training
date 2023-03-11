using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Game.Installers
{
    public class PlayerInstallers : MonoBehaviour
    {
        private Jump _jump;
        private Move _move;
        private Rotate _rotate;

        [SerializeField] PlayerController playerController;

        private void Awake()
        {
            _jump = new Jump();
            _move = new Move();
            _rotate = new Rotate();
        }

        private void Start()
        {
            playerController.Initialize(_move, _jump, _rotate);
        }
    }
}