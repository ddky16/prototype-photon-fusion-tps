using UnityEngine;

namespace Widwicky.Player.Config
{
    [CreateAssetMenu(fileName = "Player Configuration", menuName = "Scriptable/Player/Configuration", order = 0)]
    public class PlayerConfiguration : ScriptableObject
    {
        [SerializeField] private float crouchSpeed;
        [SerializeField] private float runSpeed;
        [SerializeField] private float walkSpeed;
        [SerializeField] private float jumpForce;
        
        public float CrouchSpeed => crouchSpeed;
        public float RunSpeed => runSpeed;
        public float WalkSpeed => walkSpeed;
        public float JumpForce => jumpForce;
    }
}