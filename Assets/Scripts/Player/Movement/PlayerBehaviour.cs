using System;
using UnityEngine;

namespace Widwicky.Player.Movement
{
    public class PlayerBehaviour
    {
        private CharacterController _controller;
        private Transform _position;
        private float _verticalVelocity;
        private readonly float _currentHeight;

        public PlayerBehaviour(CharacterController controller)
        {
            _controller = controller;
            _position = controller.transform;
            _currentHeight = _controller.height;
        }

        public void Move(Vector3 direction, float speed)
        {
            if (_controller.isGrounded)
                _verticalVelocity = -1f;
            else
                _verticalVelocity += Physics.gravity.y * Time.deltaTime;

            var move = (direction * speed) + Vector3.up * _verticalVelocity;
            _controller.Move(move * Time.deltaTime);
        }
        
        public void Jump(float jumpForce)
        {
            if (_controller.isGrounded)
                _verticalVelocity = jumpForce;
        }
        
        public bool IsFalling()
        {
            return !_controller.isGrounded && _verticalVelocity < 0;
        }
        
        public void Crouch(bool isCrouching)
        {
            _controller.height = isCrouching ? _controller.height / 2 : _currentHeight;
        }

        public float Velocity => _controller.velocity.magnitude;
    }
}
