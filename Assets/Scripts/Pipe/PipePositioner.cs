using UnityEngine;

namespace Scripts.Pipe
{
    public class PipePositioner
    {
        public void SetPipePos(GameObject pipe, float bottomMinY, float bottomMaxY, float distance)
        {
            var posBot = Random.Range(bottomMinY, bottomMaxY);
            var pipeBot = pipe.transform.GetChild(1);
            pipeBot.transform.localPosition = Vector3.up * posBot;

            var posTop = posBot + distance;
            var pipeTop = pipe.transform.GetChild(0);
            pipeTop.transform.localPosition = Vector3.up * posTop;
        }
    }
}

