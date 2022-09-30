using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallJump : MonoBehaviour
{
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
        Debug.Log("Label 1");
        if (collision.gameObject.CompareTag("dblock"))
        {
            Jump();
        }
    }

    private void Jump()
    {   
        Debug.Log("Label 1");
        _directionJump.y = _farceJump;
        _rigidbody.AddForce(_directionJump);
    }
}
