using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Character
{
    [System.Serializable]
    public class RandomSkinChooser
    {
        [SerializeField] private Skins[] skinks;
        private int _skinNo;

        private List<Sprite> _characterSkin = new List<Sprite>();

        public void SetCharacterSkin()
        {
            _skinNo = Random.Range(0, skinks.Length);

            for (int i = 0; i < skinks[_skinNo].sprites.Length; i++)
            {
                _characterSkin.Add(skinks[_skinNo].sprites[i]);
            }
        }

        public List<Sprite> GetCharacterSkin()
        {
            return _characterSkin;
        }

        public Sprite GetDefSprite()
        {
            return _characterSkin[_characterSkin.Count - 1];
        }
    }
}

