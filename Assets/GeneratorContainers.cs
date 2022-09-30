using UnityEngine;

public class GeneratorContainers : MonoBehaviour
{
    #region Data
    [SerializeField] [Range(1, 10)] private int offsetBetweenContainers;
    #endregion

    [SerializeField] private GameObject[] _prefabs;
    [SerializeField] private Transform _parent;
    // Start is called before the first frame update
    void Start()
    {
        int currentPosition = offsetBetweenContainers;
        for (int i = 1; i <= 10; i++)
        {
            var item = Instantiate(_prefabs[Random.Range(0, _prefabs.Length)], _parent);

            item.transform.position = new Vector3(0, i * offsetBetweenContainers, 0);
        }
    }
}
