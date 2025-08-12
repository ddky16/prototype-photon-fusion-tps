using System;
using UnityEngine;
using Widwicky.Player.Config;
using Widwicky.Player.Input;
using Widwicky.Player.Movement;

namespace Widwicky.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerConfiguration configuration;
        
        private CharacterController _controller;
        private PlayerBehaviour _behaviour;
        private PlayerController _inputControl;
        
        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
            _behaviour = new PlayerBehaviour(_controller);
            _inputControl = new PlayerController();
        }

        private void OnEnable()
        {
            _inputControl.Enable();
        }

        private void OnDisable()
        {
            _inputControl.Disable();
        }

        private void Update()
        {
            _behaviour.Move(_inputControl.Direction, configuration.WalkSpeed);
        }
    }
}