using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreRotation : MonoBehaviour
{
    [SerializeField] private SwipeDetection _swipeDetection;
    private Transform _trasform;
    [SerializeField] [Range(1, 8)] private float _velocityRotate;
    // Start is called before the first frame update
    void Start()
    {
        _velocityRotate = 5;
        _trasform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (_swipeDetection.IsSwipeLeft)
            Rotation(-1);
        else if (_swipeDetection.IsSwipeRight)
            Rotation(1);
    }

    private void Rotation(int value)
    {
        float angle = value * _velocityRotate;
        _trasform.Rotate(new Vector3(0, angle, 0));
    }
}
