using Framework.UltraHUD;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Shared.Dungeon.Scripts
{
    public class DieOnCollision : MonoBehaviour
    {
        public PlayerDataScriptable playerData;
        public string levelName;

        private void OnTriggerEnter2D(Collider2D other)
        {
            playerData.deaths++;
            SceneManager.LoadScene(levelName);
        }
    }
}
