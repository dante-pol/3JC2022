using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAcceleration : IBallBehaviour
{
    private Ball _ball;

    public BallAcceleration(Ball ball)
    {
        _ball = ball;
    }

    public void Behaviour()
    {
        throw new System.NotImplementedException();
    }
}