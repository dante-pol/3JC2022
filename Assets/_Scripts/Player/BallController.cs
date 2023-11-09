using UnityEngine;

namespace Root.Assets._Scripts.Player
{
    public class BallController
    {
        private readonly Ball _ball;

        private int _countPassedRings;
        private Vector3 _directionJump;

        public BallController(Ball ball)
        {
            _ball = ball;

            _directionJump = new Vector3(0, ball.ForceJump, 0);
        }

        public void Jump()
        {
            _directionJump.y = _ball.ForceJump;
            _ball.GetRigidbody.AddForce(_directionJump, ForceMode.Force);
        }

        public void IncreasePassedRings()
        {
            _countPassedRings++;
            
            if (_countPassedRings == _ball.StepsForShield)
            {
                _ball.ActiveShield();
                ResetPassedRings();
            }
        }

        private void ResetPassedRings()
        {
            _countPassedRings = 0;
        }
    }
}