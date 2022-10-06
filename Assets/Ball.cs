using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour
{
    public bool IsLive { get; private set; }
    public float ForceJump => _farceJump;
    public Rigidbody GetRigidbody => _rigidbody;

    public event Action OnPassing;

    #region BallBehaviour
    private IBallBehaviour _ballJump;
    private IBallBehaviour _ballDestroy;
    #endregion

    private Rigidbody _rigidbody;
    [SerializeField][Range(1f, 1000f)] private float _farceJump;
    // Start is called before the first frame update
    void Awake()
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
        else if (true)
        {

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
