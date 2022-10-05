using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RingExplosion : MonoBehaviour
{
    [SerializeField][Range(2, 10)] private float _explosionForce;
    [SerializeField][Range(2, 15)] private float _explosionRadius;
    [SerializeField] private BallJump _ball;

    private void OnEnable()
    {
        Debug.Log("Lalala1");
        _ball.OnPassing += StartExplosion;
    }

    private void OnDisable()
    {
        Debug.Log("Lalala2");
        _ball.OnPassing -= StartExplosion;
    }

    private void StartExplosion()
    {
        Debug.Log("Lalala");
        GetComponent<Rigidbody>().AddExplosionForce(
            _explosionForce,
            transform.position,
            _explosionRadius,
            0.0f,
            ForceMode.Force);
    }
}

