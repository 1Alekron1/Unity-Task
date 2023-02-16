using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public bool IsJoined = true;
        public int CoolDown;
        private Player _player;
        private Rigidbody2D _rigidbody2D;
        void Start()
        {
            _player = GetComponent<Player>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_player.IsJoined)
                    _rigidbody2D.gravityScale /= 1.5f;
                _player.IsJoined = false;
                _player.CoolDown = 100;
            }

            if (_player.CoolDown > 0)
                _player.CoolDown -= 1;
        }
    }
}