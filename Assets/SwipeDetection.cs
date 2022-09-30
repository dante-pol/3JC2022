using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeDetection : MonoBehaviour
{
    public bool IsSwipeRight { get; private set; }
    public bool IsSwipeLeft { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                if (Input.GetTouch(0).deltaPosition.x > 0)
                    IsSwipeRight = true;
                else
                    IsSwipeLeft = true;
            }
        }
        else
        {
            ResetSwipe();
        }

    }

    private void ResetSwipe()
    {
        IsSwipeRight = false;
        IsSwipeLeft = true;
    }
}
