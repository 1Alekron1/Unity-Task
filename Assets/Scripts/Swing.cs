using UnityEngine;

public class Swing : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (_rigidbody2D.velocity.x < 3.5 && _rigidbody2D.velocity.x > -3.5)
        {
            var speed = 4.5f;
            if (_rigidbody2D.velocity.x > 0 && _rigidbody2D.velocity.y > 0)
                _rigidbody2D.AddForce(new Vector2(0.5f, 0.5f) * speed);
            else if (_rigidbody2D.velocity.x < 0 && _rigidbody2D.velocity.y < 0)
                _rigidbody2D.AddForce(new Vector2(-0.5f, -0.5f) * speed);
            else if (_rigidbody2D.velocity.x < 0 && _rigidbody2D.velocity.y > 0)
                _rigidbody2D.AddForce(new Vector2(-0.5f, 0.5f) * speed);
            else if (_rigidbody2D.velocity.x > 0 && _rigidbody2D.velocity.y < 0)
                _rigidbody2D.AddForce(new Vector2(0.5f, -0.5f) * speed);
        }
    }
}