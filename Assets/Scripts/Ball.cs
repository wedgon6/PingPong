using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    private Transform _transform;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _transform = transform;
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void SetVelosity(Vector3 velosity)
    {
        _rigidbody.velocity = velosity;
    }

    public Vector3 GetPosition()
    {
        return _transform.position;
    }

    internal void SetPosition(Vector3 startPoint)
    {
        _transform.position = startPoint;
    }
}
