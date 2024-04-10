using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower 
{
    public Vector3 CalculateVelocityHeight(Vector3 startPoint, Vector3 endPoint, float height)
    {
        float timeToRise = CalculateTimeByHeight(height);
        float timeToFall = CalculateTimeByHeight(height + (startPoint-endPoint).y);
        
        Vector3 horizontalVelocity = endPoint - startPoint;
        horizontalVelocity.y = 0;
        horizontalVelocity /= (timeToRise + timeToRise);

        Vector3 verticalVelocity = -Physics.gravity * timeToRise;

        return horizontalVelocity + verticalVelocity;
    }

    private float CalculateTimeByHeight(float height)
    {
        var g = Mathf.Abs(Physics.gravity.y);

        return Mathf.Sqrt((2f * height) / g);
    }
}
