using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public bool IsJoined = true;
        public int CoolDown;
        private Player _player;
        private Rigidbody2D _rigidbody2D;

        private void Start()
        {
            _player = GetComponent<Player>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (_player.CoolDown > 0)
                _player.CoolDown -= 1;
        }

        public void UnhookPlayer()
        {
            if (_player.IsJoined)
                _rigidbody2D.gravityScale /= 1.5f;
            _player.IsJoined = false;
            _player.CoolDown = 100;
        }
    }
}