using Root.Assets._Scripts.Ring;
using System;
using UnityEngine;

namespace Root.Assets._Scripts.Player
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

        public int StepsForShield { get; private set; }
        public bool IsAtiveShield { get; private set; }        

        public Rigidbody GetRigidbody => _rigidbody;
        private Rigidbody _rigidbody;

        #region BallBehaviour
        private BallController _ballController;
        private BallDestroy _ballDestroy;
        #endregion

        private void Start()
        {
            _ballController = new BallController(this);
            _ballDestroy = new BallDestroy(this);

            StepsForShield = 3;
            IsAtiveShield = false;
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (IsAtiveShield)
            {
                _ballController.Jump();

                OnPassing?.Invoke();
                collision.gameObject.GetComponentInParent<RingContainer>().RunExplosion();

                ResetShield();
            }
            else if (collision.gameObject.CompareTag("dblock"))
            {
                _ballController.Jump();
            } 
            else if (collision.gameObject.CompareTag("eblock"))
            {
                OnDead?.Invoke();
                _ballDestroy.Destroy();
            }

            _ballController.ResetPassedRings();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("lblock"))
            {
                _ballController.IncreasePassedRings();
                OnPassing?.Invoke();
                other.GetComponent<RingContainer>().RunExplosion();
            }
        }

        public void ActiveShield()
        {
            IsAtiveShield = true;
        }

        public void ResetShield()
        {
            IsAtiveShield = false;
        }
    }
}