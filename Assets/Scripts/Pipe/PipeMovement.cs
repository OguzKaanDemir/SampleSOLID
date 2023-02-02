using UnityEngine;
using DG.Tweening;

namespace Scripts.Pipe
{
    public class PipeMovement : MonoBehaviour
    {
        private float finishPosX = -15f;
        private Sequence _seq;

        private void Start()
        {
            _seq = DOTween.Sequence();

            _seq.SetEase(Ease.Linear)
               .Append(transform.DOMoveX(finishPosX, PipeSpawner.Ins.pipeManager.properties[PipeSpawner.Ins.dataIndex].lifeTime))
               .OnUpdate(() =>
               {
                   if (!GameManager.Ins.isGameRunning) _seq.Kill();
               })
               .OnComplete(() =>
               {
                   _seq.Kill();
                   Destroy(gameObject);
               });
        }
    }
}

