using UnityEngine;

namespace DefaultNamespace
{
    public class Swaying : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Player _player;
        private float _criticalVelocity = 3.5f;
        private float _power = 0.5f;
        private float _speed = 4.5f;
        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _player = GetComponent<Player>();
        }

        private void Update()
        {
            if (_player.IsJoined)
                Swing();
        }

        private void Swing()
        {
            var velocity = _rigidbody2D.velocity;
            var velocityX = velocity.x;
            var velocityY = velocity.y;
            if (velocityX < _criticalVelocity && velocityX > -_criticalVelocity)
            {
                if (velocityX > 0 && velocityY > 0)
                    AddForce(_power, _power);
                else if (velocityX < 0 && velocityY < 0)
                    AddForce(-_power, -_power);
                else if (velocityX < 0 && velocityY > 0)
                    AddForce(-_power, _power);
                else if (velocityX > 0 && velocityY < 0)
                    AddForce(_power, -_power);
            }
        }

        private void AddForce(float x, float y)
        {
            
            _rigidbody2D.AddForce(new Vector2(x, y) * _speed);
        }
    }
}