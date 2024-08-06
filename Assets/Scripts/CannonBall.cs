using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    // handle projectile trajectory
    // add physics to cannonball
    // create explosions
    // control explosion particle effect

    private Rigidbody ballRb;

    private void Awake()
    {
        ballRb = GetComponent<Rigidbody>();
    }
}
