using Scripts.Managers;
using UnityEngine;

namespace Scripts.Player
{
    [System.Serializable]
    public class PlayerController
    {
        [SerializeField] private Rigidbody2D _rb;
        [SerializeField] private float _jumpForce;
        private InputManager _input = new InputManager();
        private Jump _jump = new Jump();

        public void Jump()
        {
            if (_input.CheckClick() && GameManager.Ins.isGameRunning)
                _jump.JumpAction(_rb, _jumpForce);
        }
    }
}

