using Framework.InputManager;
using UnityEngine;

namespace Game.Shared.Player.Scripts
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed;
        
        private Rigidbody2D _rigidbody2D;
        
        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            InputManager.Instance.OnMove += OnMove;
        }

        private void OnMove(Vector2 direction)
        {
            _rigidbody2D.velocity = direction * speed;
        }
    }
}
