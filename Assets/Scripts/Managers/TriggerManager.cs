using Scripts.Audio;
using Scripts.Character;
using Scripts.Pipe;
using Scripts.UI;
using UnityEngine;

namespace Scripts.Managers
{
    [System.Serializable]
    public class TriggerManager
    {
        private PipeController _pipeController = new PipeController();
        private ScoreController _scoreController = new ScoreController();
        private CharacterDieController _characterDieController = new CharacterDieController();

        public void CheckTrigger(Collider2D col)
        {
            if (col.CompareTag("ScoreArea"))
            {
                _pipeController.SetPipe();
                _scoreController.SetScore();
                AudioManager.Ins.PlaySFXOnce("score");

            }
            else if (col.gameObject.CompareTag("Pipe") || col.gameObject.CompareTag("Platform") || col.gameObject.CompareTag("Limit"))
            {
                _characterDieController.OnDie();
                AudioManager.Ins.PlaySFXOnce("hit");
            }
        }
    }
}

