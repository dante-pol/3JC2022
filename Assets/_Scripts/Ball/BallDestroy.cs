using UnityEngine;

namespace Root.Assets._Scripts.Ball
{
    class BallDestroy : IBallBehaviour
    {
        private Ball _ball;

        public BallDestroy(Ball ball)
        {
            _ball = ball;
        }

        public void Behaviour()
        {
            throw new System.NotImplementedException();
        }
    }
}