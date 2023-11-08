using UnityEngine;

namespace Root.Assets._Scripts.Game
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField][Range(0, 5)] private float _speedFollow;
        private Transform _transform;
        private Vector3 _direction;

        private void Start()
        {
            _transform = transform;
            _direction = _transform.position;
            _direction.y = _transform.position.y;
        }


        private void LateUpdate()
        {
            _direction.y = _target.position.y;
            _transform.position = Vector3.Lerp(_transform.position, _direction, _speedFollow * Time.smoothDeltaTime);
        }
    }
}