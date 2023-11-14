using System.Collections.Generic;
using UnityEngine;

namespace Root.Assets._Scripts.Player
{
    public class BallSpot
    {
        private Ball _ball;
        private Transform _parent;

        public SpotPooling GetPooling => _spotPooling;
        private SpotPooling _spotPooling;

        public BallSpot(Ball ball)
        {
            _ball = ball;
            
            _spotPooling = new SpotPooling(this, _ball.SpotPrefab, 10);
            _parent = _ball.SpotParent;
        }


        public void MakeSpot(Vector3 position)
        {
            var newPos = new Vector3(_ball.transform.position.x, position.y, _ball.transform.position.z);
            var spot = _spotPooling.Extract();
            spot?.Activate(newPos, _parent);
        }

        public class SpotPooling
        {
            public int MaxSize { get; private set; }
            public int CountAll { get; private set; }

            public readonly BallSpot Pooling;

            private Spot _prefab;
            private Stack<Spot> _pools;

            public SpotPooling(BallSpot ballSpot, Spot prefab, int maxSize = -1)
            {
                MaxSize = maxSize;
                _prefab = prefab;

                _pools = new Stack<Spot>();
                Pooling = ballSpot;
            }

            public void Add(Spot objectPool)
            {
                _pools.Push(objectPool);
                //objectPool.gameObject.SetActive(false);
            }

            public Spot Extract()
            {
                if (CountAll == MaxSize && _pools.Count == 0) return null;
                
                Spot objectPool;
                
                if (_pools.Count != 0)
                    objectPool = _pools.Pop();
                else 
                    objectPool = Create();

                return objectPool;

            }

            private Spot Create()
            {
                Spot newObjectPool = Object.Instantiate(_prefab);
                newObjectPool.InitObjectPool(Pooling);
                CountAll++;

                return newObjectPool;
            }
        }
    }
}
