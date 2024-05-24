using UnityEngine;

namespace Game.Shared.Player.Scripts
{
    public class PlayerAnimation : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Animator _animator;
        private SpriteRenderer _spriteRenderer;
        
        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _animator = GetComponentInChildren<Animator>();
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        }

        private void Update()
        {
            _animator.SetFloat("speed", Mathf.Abs(_rigidbody2D.velocity.magnitude));
            
            if (_rigidbody2D.velocity.x > Mathf.Epsilon)
                _spriteRenderer.flipX = false;
            if (_rigidbody2D.velocity.x < -Mathf.Epsilon)
                _spriteRenderer.flipX = true;
        }
    }
}
