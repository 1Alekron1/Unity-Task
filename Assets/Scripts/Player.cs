using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        public bool IsJoined = true;
        public int CoolDownCounter;
        private Player _player;
        private Rigidbody2D _rigidbody2D;
        private int _coolDownTime = 100;
        private float _gravityReduction = 1.5f;

        private void Start()
        {
            _player = GetComponent<Player>();
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (_player.CoolDownCounter > 0)
                _player.CoolDownCounter -= 1;
        }

        public void UnhookPlayer()
        {
            if (_player.IsJoined)
                _rigidbody2D.gravityScale /= _gravityReduction;
            _player.IsJoined = false;
            _player.CoolDownCounter = _coolDownTime;
        }
    }
}