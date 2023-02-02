using Scripts.Audio;
using UnityEngine;

namespace Scripts.Player
{
    public class Jump
    {
        public void JumpAction(Rigidbody2D rb, float jumpForce)
        {
            rb.velocity = Vector2.up * jumpForce;
            AudioManager.Ins.PlaySFX("jump");
        }
    }
}

