using UnityEngine;

namespace Root.Assets._Scripts.Ring
{
    [RequireComponent(typeof(Rigidbody))]
    public class ObjectExplosion : MonoBehaviour
    {
        public void DisActiveCollider()
        {
            GetComponent<Collider>().enabled = false;
        }

        public void Explosion(float explosionForce, float explosionRadius, Vector3 position)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.isKinematic = false;
            rb.AddExplosionForce(explosionForce, position, explosionRadius, -3f);
        }
    }
}