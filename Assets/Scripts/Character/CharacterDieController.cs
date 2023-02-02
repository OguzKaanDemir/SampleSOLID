using DG.Tweening;
using UnityEngine;

namespace Scripts.Character
{
    public class CharacterDieController
    {
        private void OnPlayerLose()
        {
            var rb = GameManager.Ins.player.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0f;

            GameManager.Ins.gameFinishPanel.SetActive(true);
            GameManager.Ins.platform.GetComponent<DOTweenAnimation>().DOKill();
            Player.Player.Ins.StopAnim();
        }

        public void OnDie()
        {
            GameManager.Ins.onPlayerLose += OnPlayerLose;
            GameManager.Ins.OnPlayerLose();
        }
    }
}

