using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeDetection : MonoBehaviour
{
    public bool IsSwipeRight { get; private set; } = false;
    public bool IsSwipeLeft { get; private set; } = false;

    // Update is called once per frame
    void Update()
    {
        if (InputController.IsTouch)
        {
            Touch touch = InputController.GetTouch;
            if (touch.phase == TouchPhase.Moved)
            {
                if (touch.deltaPosition.x > 0)
                    IsSwipeRight = true;
                else
                    IsSwipeLeft = true;
            }
            else
            {
                ResetSwipe();
            }
        }
    }

    private void ResetSwipe()
    {
        IsSwipeRight = false;
        IsSwipeLeft = false;
    }
}
