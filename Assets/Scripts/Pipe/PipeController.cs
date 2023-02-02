namespace Scripts.Pipe
{
    public class PipeController
    {
        public void SetPipe()
        {
            if (PipeSpawner.Ins.pipeManager.properties[PipeSpawner.Ins.dataIndex + 1].targetScore == GameManager.Ins.score
                    && PipeSpawner.Ins.dataIndex + 1 < PipeSpawner.Ins.pipeManager.properties.Count)
                PipeSpawner.Ins.dataIndex++;
        }
    }
}

