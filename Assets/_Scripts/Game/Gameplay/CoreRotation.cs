using UnityEngine;

namespace Root.Assets._Scripts.Game.Gameplay
{
    public class CoreRotation : MonoBehaviour
    {
        [SerializeField] private SwipeDetection _swipeDetection;
        [SerializeField][Range(1, 8)] private float _velocityRotate;
        private Transform _trasform;

        public void Start()
        {
            _velocityRotate = 3.5f;
            _trasform = transform;
        }

        private void Update()
        {
            if (!InputSystem.IsPlay) return;

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
}