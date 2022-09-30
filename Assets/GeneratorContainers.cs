using UnityEngine;

public class GeneratorContainers : MonoBehaviour
{
    #region Data
    [SerializeField] [Range(1, 10)] private int _offsetBetweenContainers;
    [SerializeField][Range(5, 20)] private int _countContainers;
    public int OffsetBetweenContainers => _offsetBetweenContainers;
    public int CountContainers => _countContainers;
    #endregion

    [SerializeField] private GameObject[] _prefabs;
    [SerializeField] private Transform _parent;
    // Start is called before the first frame update
    void Awake()
    {
        int currentPosition = _offsetBetweenContainers;
        for (int i = 1; i <= _countContainers; i++)
        {
            var item = Instantiate(_prefabs[Random.Range(0, _prefabs.Length)], _parent);

            item.transform.position = new Vector3(0, i * _offsetBetweenContainers, 0);
        }
    }
}
