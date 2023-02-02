using System.Collections;
using UnityEngine;

namespace Scripts.Character
{
    [System.Serializable]
    public class CharacterAnimationController
    {
        [SerializeField] float _animSpeed = .1f;

        public SpriteRenderer _spriteRenderer;
        public bool canPlay = true;

        public IEnumerator BirdAnim()
        {
             while (canPlay)
             {
                 foreach (var item in Player.Player.Ins.skin.GetCharacterSkin())
                 {
                     _spriteRenderer.sprite = item;
                     yield return new WaitForSeconds(_animSpeed);
                 }
             }
        }
    }
}
