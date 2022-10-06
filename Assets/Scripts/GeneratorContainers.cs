using System.Data;
using UnityEngine;

public class GeneratorContainers : MonoBehaviour
{
    #region DataGenerator
    [Header("Data generator")]
    [SerializeField][Range(1, 10)] private int _offsetBetweenContainers;
    [SerializeField][Range(5, 100)] private int _countContainers;
    public int OffsetBetweenContainers => _offsetBetweenContainers;
    public int CountContainers => _countContainers;
    #endregion

    #region DataRing
    [Header("Data ring")]
    [SerializeField][Range(800, 5000)] private float _explosionForce;
    [SerializeField][Range(2, 10)] private float _explosionRadius;
    #endregion

    [SerializeField] private RingContainer[] _prefabs;
    [SerializeField] private BallJump _ball;
    [SerializeField] private Transform _parent;

    // Start is called before the first frame update
    void Awake()
    {
        int currentPosition = _offsetBetweenContainers;
        for (int i = 1; i <= _countContainers; i++)
        {
            var item = Instantiate(_prefabs[Random.Range(0, _prefabs.Length)], _parent);
            item.Inisialization(_ball, _explosionForce, _explosionRadius);
            item.transform.position = new Vector3(0, i * _offsetBetweenContainers, 0);
        }
    }
}
