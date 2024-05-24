using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Shared.Dungeon.Scripts
{
    public class LoadOnCollision : MonoBehaviour
    {
        public string levelName;

        private void OnTriggerEnter2D(Collider2D other)
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
