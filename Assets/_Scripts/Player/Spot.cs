using System.Collections;
using UnityEngine;

namespace Root.Assets._Scripts.Player
{
    public class Spot : MonoBehaviour
    {
        private float _timeLife = 1.5f;
        
        private BallSpot _ballSpot;

        public void InitObjectPool(BallSpot ballSpot)
        {
            _ballSpot = ballSpot;
        }

        public void Activate(Vector3 position, Transform parent)
        { 
            position.y += 1.05f;
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