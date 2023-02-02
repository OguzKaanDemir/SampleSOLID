using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Scripts.UI
{
    public class GameFinishPanel : MonoBehaviour
    {
        private static GameFinishPanel _ins;

        public static GameFinishPanel Ins
        {
            get
            {
                if (_ins == null)
                    _ins = FindObjectOfType<GameFinishPanel>();

                return _ins;
            }
        }

        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private TMP_Text _bestScoreText;
        [SerializeField] private GameObject _goldMedal; 
        [SerializeField] private GameObject _ironMedal; 

        private BestScore _bestScore;

        private void OnEnable()
        {
            FindObjectOfType<GamePanel>().gameObject.SetActive(false);
            _bestScore = (BestScore)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Resources/Score/BestScore.asset", typeof(BestScore));

            _bestScore.LoadData();
            SetScoreAndMedal();
            ShowScore();
        }

        private void SetScoreAndMedal()
        {
            if (_bestScore.bestScore < GameManager.Ins.score)
            {
                _bestScore.bestScore = GameManager.Ins.score;
                _bestScore.SaveScore();
                _goldMedal.SetActive(true);
            }
            else
                _ironMedal.SetActive(true);
        }

        private void ShowScore()
        {
            _scoreText.text = GameManager.Ins.score.ToString();
            _bestScoreText.text = _bestScore.bestScore.ToString();
        }

        public void BTN_Start()
        {
            SceneManager.LoadScene(0);
        }
    }
}

