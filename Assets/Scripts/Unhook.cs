using UnityEngine;

public class Unhook : MonoBehaviour
{
    private HingeJoint2D _hingeJoint2D;

    void Start()
    {
        _hingeJoint2D = GetComponent<HingeJoint2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _hingeJoint2D.enabled = false;
        }
    }
}