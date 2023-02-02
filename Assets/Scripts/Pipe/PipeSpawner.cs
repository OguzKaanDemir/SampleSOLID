using Scripts.Managers;
using System.Collections;
using UnityEngine;

namespace Scripts.Pipe
{
    public class PipeSpawner : MonoBehaviour
    {
        private static PipeSpawner _ins;

        public static PipeSpawner Ins
        {
            get
            {
                if (_ins == null)
                    _ins = FindObjectOfType<PipeSpawner>();

                return _ins;
            }
        }

        public int dataIndex = 0;

        [SerializeField] public GameObject redPipe;
        [SerializeField] public GameObject greenPipe;

        [HideInInspector] public PipeManager pipeManager;

        [SerializeField] private Transform _spawnPoint;

        [SerializeField] private float _bottomMinY;
        [SerializeField] private float _bottomMaxY;


        private PipePositioner _pipePositioner = new PipePositioner();
        private PipeColorPicker _pipeColorPicker = new PipeColorPicker();


        private void Start()
        {
            pipeManager = (PipeManager)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Resources/Pipe/PipeProperties.asset", typeof(PipeManager));
        }

        private IEnumerator SpawnPipe()
        {
            while (GameManager.Ins.isGameRunning)
            {
                CreatePipe(_pipeColorPicker.GetPipe());
                yield return new WaitForSeconds(pipeManager.properties[dataIndex].delay);
            }
        }

        private void CreatePipe(GameObject pipe)
        {
            var newPipe = Instantiate(pipe, _spawnPoint);

            _pipePositioner.SetPipePos(newPipe, _bottomMinY, _bottomMaxY, pipeManager.properties[dataIndex].distance);
        }

        public void StartSpawn()
        {
            StartCoroutine(SpawnPipe());
        }
    }
}
