using System;
using UnityEngine;

namespace Game.Shared.Enemy.Scripts
{
    public class EnemyStateManager : MonoBehaviour
    {
        private enum EnemyState
        {
            Sleeping = 0,
            Following = 1
        };

        private EnemyState _enemyState;
        private EnemyFollow _enemyFollow;

        public float wakeRadius;

        private void Start()
        {
            _enemyFollow = GetComponent<EnemyFollow>();
            
            _enemyState = EnemyState.Sleeping;
            _enemyFollow.enabled = false;
        }

        private void Update()
        {
            switch (_enemyState)
            {
                case EnemyState.Sleeping:
                    var hit = Physics2D.OverlapCircle(transform.position, wakeRadius);
                    if (hit.CompareTag("Player"))
                        ChangeState(EnemyState.Following);
                    break;
                case EnemyState.Following:
                    break;
            }
        }
        
        [ExecuteInEditMode]
        void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position, wakeRadius);
        }
        
        private void ChangeState(EnemyState newState)
        {
            switch (newState)
            {
                case EnemyState.Following:
                    _enemyFollow.enabled = true;
                    break;
            }

            _enemyState = newState;
        }
    }
}
