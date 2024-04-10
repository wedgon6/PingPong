using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public event Action ColisionEnterd;

    private void OnCollisionEnter(Collision collision)
    {
        var rigitbody = collision.collider.attachedRigidbody;

        if (rigitbody != null)
        {
            if(rigitbody.GetComponent<Ball>() != null)
            {
                ColisionEnterd?.Invoke();
            }
        }
    }
}
