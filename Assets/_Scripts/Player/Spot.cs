using System.Collections;
using UnityEngine;

namespace Root.Assets._Scripts.Player
{
    public class Spot : MonoBehaviour
    {
        [SerializeField] private float _timeLife = 5.5f;
        
        private BallSpot _ballSpot;

        public void InitObjectPool(BallSpot ballSpot)
        {
            _ballSpot = ballSpot;
        }

        public void Activate(Vector3 position, Transform parent)
        {
            transform.position = position;
            transform.parent = parent;

            StartCoroutine(Life());
        }

        private IEnumerator Life()
        {
            yield return new WaitForSeconds(_timeLife);

            _ballSpot.GetPooling.Add(this);
        }
    }
}