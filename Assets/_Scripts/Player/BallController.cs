using UnityEngine;

namespace Root.Assets._Scripts.Player
{
    public class BallController
    {
        public bool IsJump { get; private set; }

        private readonly Ball _ball;

        private int _countPassedRings;
        private Vector3 _directionJump;

        public BallController(Ball ball)
        {
            _ball = ball;

            _directionJump = new Vector3(0, ball.ForceJump, 0);
        }

        public void Update()
        {

        }

        public void Jump()
        {
            _ball.GetRigidbody.velocity = _directionJump;
            IsJump = false;
        }

        public void IncreasePassedRings()
        {
            _countPassedRings++;
            
            if (_countPassedRings == _ball.StepsForShield)
                _ball.ActiveShield();
        }

        public void ResetPassedRings()
            => _countPassedRings = 0;
    }
}