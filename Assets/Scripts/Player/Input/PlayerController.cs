using UnityEngine;

namespace Widwicky.Player.Input
{
    public class PlayerController
    {
        private readonly PlayerInputSystem _inputSystem = new();

        public void Enable()
        {
            _inputSystem.Enable();
        }

        public void Disable()
        {
            _inputSystem.Disable();
        }

        public Vector3 Direction
        {
            get
            {
                Vector3 direction = _inputSystem.Player.Move.ReadValue<Vector2>();
                return new Vector3(direction.x, 0, direction.y);
            }
        }
        
        public Vector2 Direction2D => _inputSystem.Player.Move.ReadValue<Vector2>();
        public Vector2 Aiming => _inputSystem.Player.Look.ReadValue<Vector2>();
        public bool Jump => _inputSystem.Player.Jump.triggered;
    }
}