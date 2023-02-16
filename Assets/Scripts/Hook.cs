using UnityEngine;

namespace DefaultNamespace
{
    public class Hook : MonoBehaviour
    {
        private HingeJoint2D _hingeJoint2D;

        void Start()
        {
            _hingeJoint2D = GetComponent<HingeJoint2D>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.GetComponent<Player>();
            var component = other.GetComponent<Rigidbody2D>();
            if (!player.IsJoined && player.CoolDown == 0)
            {
                _hingeJoint2D.connectedBody = component;
                player.IsJoined = true;
                _hingeJoint2D.enabled = true;
                component.gravityScale *= 1.5f;
            }
        }
    }
}