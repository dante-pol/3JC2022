using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ObjectExplosion : MonoBehaviour
{
    public void Explosion(float explosionForce, float explosionRadius, Vector3 position)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.AddExplosionForce(explosionForce, position, explosionRadius, 15.0F);

    }
}
