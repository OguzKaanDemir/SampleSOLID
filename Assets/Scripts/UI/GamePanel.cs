using TMPro;
using UnityEngine;

namespace Scripts.UI
{
    public class GamePanel : MonoBehaviour
    {
        private static GamePanel _ins;

        public static GamePanel Ins
        {
            get
            {
                if (_ins == null)
                    _ins = FindObjectOfType<GamePanel>();

                return _ins;
            }
        }

        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] public GameObject gameFinishPanel;

        private void Start()
        {
            SetScore(0);
        }

        private void ShowScore()
        {
            _scoreText.text = GameManager.Ins.score.ToString();
        }

        public void SetScore(int value)
        {
            GameManager.Ins.score = value;
            ShowScore();
        }
    }
}

