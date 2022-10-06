using System;
using UnityEngine;

public class BallJump : IBallBehaviour
{
    private Ball _ball;
    private Vector3 _directionJump;

    public BallJump(Ball ball)
    {
        _ball = ball;
        _directionJump = new Vector3(0, ball.ForceJump, 0);
    }

    public void Behaviour()
    {
        _directionJump.y = _ball.ForceJump;
        _ball.GetRigidbody.AddForce(_directionJump, ForceMode.Force);
    }
}
