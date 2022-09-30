using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField][Range(0, 5)] private float _speedFollow;
    private Transform _transform;
    private Vector3 _direction;
    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
        _direction = _transform.position;
        _direction.y = _transform.position.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        _direction.y = _target.position.y;
        _transform.position = Vector3.Lerp(_transform.position, _direction, _speedFollow * Time.deltaTime);
    }
}
