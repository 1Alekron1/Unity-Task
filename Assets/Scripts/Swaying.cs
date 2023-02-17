using UnityEngine;

namespace DefaultNamespace
{
    public class Swaying : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Player _player;

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
            if (velocityX < 3.5 && velocityX > -3.5)
            {
                if (velocityX > 0 && velocityY > 0)
                    AddForce(0.5f, 0.5f);
                else if (velocityX < 0 && velocityY < 0)
                    AddForce(-0.5f, -0.5f);
                else if (velocityX < 0 && velocityY > 0)
                    AddForce(-0.5f, 0.5f);
                else if (velocityX > 0 && velocityY < 0)
                    AddForce(0.5f, -0.5f);
            }
        }

        private void AddForce(float x, float y)
        {
            var speed = 4.5f;
            _rigidbody2D.AddForce(new Vector2(x, y) * speed);
        }
    }
}