using System;
using UnityEngine;

namespace Widwicky.Player.Animation
{
    public class PlayerAnimation : MonoBehaviour
    {
        private Animator _animator;

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        public void Move(Vector2 direction, float velocity)
        {
            _animator.SetFloat("x", direction.x, 0.1f, Time.deltaTime);
            _animator.SetFloat("y", direction.y, 0.1f, Time.deltaTime);
            _animator.SetFloat("velocity", velocity);
        }

        public void Run(bool isRunning)
        {
            _animator.SetBool("is_running", isRunning);
        }

        public void Crouch(bool isCrouching)
        {
            _animator.SetBool("is_crouching", isCrouching);
        }

        public void Jump(bool isJumping)
        {
            _animator.SetBool("is_jumping", isJumping);
        }

        public void Falling(bool isFalling)
        {
            _animator.SetBool("is_falling", isFalling);
        }

        public void Grounded(bool isGrounded)
        {
            _animator.SetBool("is_grounding", isGrounded);
        }
    }
}