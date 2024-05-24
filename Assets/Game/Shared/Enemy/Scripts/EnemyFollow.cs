using UnityEngine;

namespace Game.Shared.Enemy.Scripts
{
    public class EnemyFollow : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        public Transform target;
        public float speed;
        
        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _rigidbody2D.velocity = (target.position - transform.position).normalized * speed;
        }
    }
}
