using Scripts.Character;
using Scripts.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Player
{
    public class Player : MonoBehaviour
    {
        private static Player _ins;

        public static Player Ins
        {
            get
            {
                if (_ins == null)
                    _ins = FindObjectOfType<Player>();

                return _ins;
            }
        }

        public RandomSkinChooser skin = new RandomSkinChooser();
        public PlayerController controller = new PlayerController();
        public CharacterAnimationController anim = new CharacterAnimationController();
        
        private TriggerManager _trigger = new TriggerManager();

        private void Start()
        {
            skin.SetCharacterSkin();
            anim._spriteRenderer.sprite = skin.GetDefSprite();
        }

        private void Update()
        {
            controller.Jump();
        }

        public void StartAnim()
        {
            StartCoroutine(anim.BirdAnim());
        }

        public void StopAnim()
        {
            anim.canPlay = false;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            _trigger.CheckTrigger(col);
        }
    }
}

