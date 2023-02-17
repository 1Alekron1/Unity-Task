using UnityEngine;

namespace DefaultNamespace
{
    public class Attachment : MonoBehaviour
    {
        private HingeJoint2D _hingeJoint2D;

        private void Start()
        {
            _hingeJoint2D = GetComponent<HingeJoint2D>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.GetComponent<Player>();

            if (!player.IsJoined && player.CoolDown == 0)
                AttachTo(other);
        }

        private void AttachTo(Collider2D player)
        {
            var rigidbody = player.GetComponent<Rigidbody2D>();
            _hingeJoint2D.connectedBody = rigidbody;
            player.GetComponent<Player>().IsJoined = true;
            _hingeJoint2D.enabled = true;
            rigidbody.gravityScale *= 1.5f;
        }
    }
}