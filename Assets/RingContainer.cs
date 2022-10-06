using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingContainer : MonoBehaviour
{
    [SerializeField] private ObjectExplosion[] _elements;
    private float _explosionForce;
    private float _explosionRadius;
    private BallJump _ball;

    public void Inisialization(BallJump ball, float explosionForce, float explosionRadius)
    {
        _ball = ball;
        _explosionForce = explosionForce;
        _explosionRadius = explosionRadius;
    }

    public void RunExplosion()
    {
        foreach(ObjectExplosion element in _elements)
        {
            element.Explosion(_explosionForce, _explosionRadius, transform.position);
        }
        StartCoroutine(Delete());
    }

    private IEnumerator Delete()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}

