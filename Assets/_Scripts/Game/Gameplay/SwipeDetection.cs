using UnityEngine;

namespace Root.Assets._Scripts.Game.Gameplay
{
    public class SwipeDetection : MonoBehaviour
    {
        public bool IsSwipeRight { get; private set; } = false;
        public bool IsSwipeLeft { get; private set; } = false;

        private void Update()
        {
            if (InputSystem.IsTouch)
            {
                Touch touch = InputSystem.GetTouch;
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
}