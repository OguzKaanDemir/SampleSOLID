using DG.Tweening;
using Scripts.Pipe;
using UnityEngine;

namespace Scripts.UI
{
    public class StartPanel : MonoBehaviour
    {
        private void OnGameStart()
        {
            GameManager.Ins.startPanel.SetActive(false);
            GameManager.Ins.gamePanel.SetActive(true);
            GameManager.Ins.player.GetComponent<Rigidbody2D>().gravityScale = 1f;
            GameManager.Ins.platform.GetComponent<DOTweenAnimation>().DOPlay();
            PipeSpawner.Ins.StartSpawn();
            Player.Player.Ins.StartAnim();
        }

        public void BTN_OnGameStart()
        {
            GameManager.Ins.onGameStart += OnGameStart;
            GameManager.Ins.OnGameStart();
        }
    }
}

