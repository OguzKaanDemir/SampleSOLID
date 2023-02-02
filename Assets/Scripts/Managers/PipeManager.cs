using Scripts.Pipe;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Managers
{
    [CreateAssetMenu(menuName = "Data/Pipe Properties")]
    public class PipeManager : ScriptableObject
    {
        public List<PipeProperties> properties = new List<PipeProperties>();
    }
}

