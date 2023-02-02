using UnityEngine;

namespace Scripts.UI
{
    [CreateAssetMenu(menuName = "Data/Best Score")]
    public class BestScore : ScriptableObject
    {
        public int bestScore;

        public void SaveScore()
        {
            PlayerPrefs.SetInt("bestScore", bestScore);
        }

        public void LoadData()
        {
            bestScore = PlayerPrefs.GetInt("bestScore", 0);
        }
    }
}

