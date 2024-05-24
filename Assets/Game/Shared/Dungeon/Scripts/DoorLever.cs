using System;
using UnityEngine;

namespace Game.Scenes.Fase1.Scripts
{
    public class DoorLever : MonoBehaviour
    {
        public GameObject door;
        public Sprite leverOn;

        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                door.SetActive(false);
                _spriteRenderer.sprite = leverOn;
            }
        }
    }
}
