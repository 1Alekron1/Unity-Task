using UnityEngine;

namespace DefaultNamespace
{
    public class Detachment : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;
        private HingeJoint2D _hingeJoint2D;
        private Player _player;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _hingeJoint2D = _spriteRenderer.name == "Main Character" ? null : GetComponent<HingeJoint2D>();
            _player = _spriteRenderer.name == "Main Character" ? GetComponent<Player>() : null;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_player)
                    _player.UnhookPlayer();
                else
                    _hingeJoint2D.enabled = false;
            }
        }
    }
}