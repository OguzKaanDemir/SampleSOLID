using UnityEngine;

namespace Scripts.Pipe
{
    public class PipeColorPicker
    {
        private GameObject SetColor()
        {
            var color = Random.Range(0, 2);
            GameObject obj = null;

            switch (color)
            {
                case 0:
                    obj = PipeSpawner.Ins.redPipe;
                    break;
                case 1:
                    obj = PipeSpawner.Ins.greenPipe;
                    break;
            }
            return obj;
        }

        public GameObject GetPipe()
        {
            return SetColor();
        }
    }
}

