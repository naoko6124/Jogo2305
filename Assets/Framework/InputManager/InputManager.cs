using System;
using UnityEngine;

namespace Framework.InputManager
{
    public class InputManager : MonoBehaviour
    {
        public static InputManager Instance;

        private GameInput _gameInput;

        public Action<Vector2> OnMove = direction => {};
        
        private void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(gameObject);
            
            _gameInput = new GameInput();
            ConfigureEvents();
        }

        private void OnDestroy()
        {
            _gameInput.Dispose();
        }

        private void OnEnable()
        {
            _gameInput.Enable();
        }

        private void OnDisable()
        {
            _gameInput.Disable();
        }

        private void ConfigureEvents()
        {
            _gameInput.Gameplay.Move.performed += context =>
            {
                Vector2 direction = context.ReadValue<Vector2>();
                OnMove(direction);
            };
            _gameInput.Gameplay.Move.canceled += context =>
            {
                OnMove(Vector2.zero);
            };
        }
    }
}
