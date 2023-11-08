using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[RequireComponent(typeof(BoxCollider))]
public class RingContainer : MonoBehaviour
{
    [SerializeField] private ObjectExplosion[] _elements;
    private float _explosionForce;
    private float _explosionRadius;
    private BallJump _ball;
    private BoxCollider _collider;

    public void Inisialization(BallJump ball, float explosionForce, float explosionRadius)
    {
        _ball = ball;
        _explosionForce = explosionForce;
        _explosionRadius = explosionRadius;
        _collider = GetComponent<BoxCollider>();
        transform.Rotate(Vector3.up, Random.Range(-20, 20));
    }

    public void RunExplosion()
    {
        _collider.enabled = false;
        foreach(ObjectExplosion element in _elements)
        {
            element.Explosion(_explosionForce, _explosionRadius, transform.position);
        }
        StartCoroutine(Delete());
    }

    private IEnumerator Delete()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }
}

