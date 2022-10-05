using Cinemachine.Editor;
using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallJump : MonoBehaviour
{
    public event Action OnPassing;
    [SerializeField][Range(1f, 1000f)] private float _farceJump;
    private Vector3 _directionJump;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _directionJump = new Vector3(0, _farceJump, 0);
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("dblock"))
        {
            Jump();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("lblock"))
            OnPassing?.Invoke();
    }

    private void Jump()
    {
        _directionJump.y = _farceJump;
        _rigidbody.AddForce(_directionJump);
    }
}
