using UnityEngine;

namespace Scripts.Managers
{
    public class InputManager
    {
        public bool CheckClick()
        {
            return Input.GetMouseButtonDown(0);
        }
    }
}

