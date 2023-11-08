using Root.Assets._Scripts.Ring;
using System;
using UnityEngine;

namespace Root.Assets._Scripts.Ball
{
    [RequireComponent(typeof(Rigidbody))]
    public class Ball : MonoBehaviour
    {
        #region BallData
        public bool IsLive { get; private set; }
        public float ForceJump => _farceJump;

        [SerializeField][Range(1f, 1000f)] private float _farceJump;
        #endregion

        public event Action OnPassing;
        public event Action OnDead;

        public Rigidbody GetRigidbody => _rigidbody;
        private Rigidbody _rigidbody;

        #region BallBehaviour
        private IBallBehaviour _ballJump;
        private IBallBehaviour _ballDestroy;
        private IBallBehaviour _ballAcceleration;
        #endregion

        public void Init()
        {
            _ballJump = new BallJump(this);
            _ballDestroy = new BallDestroy(this);
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("dblock"))
            {
                _ballJump.Behaviour();
            }
            else if (collision.gameObject.CompareTag("eblock"))
            {
                OnDead?.Invoke();
                _ballDestroy.Behaviour();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("lblock"))
            {
                OnPassing?.Invoke();
                other.GetComponent<RingContainer>().RunExplosion();
            }
        }
    }
}