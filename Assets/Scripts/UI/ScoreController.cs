namespace Scripts.UI
{
    public class ScoreController
    {
        public void SetScore()
        {
            GamePanel.Ins.SetScore(GameManager.Ins.score + 1);
        }
    }
}

