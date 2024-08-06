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

    public void Setup(Vector3 fireForce)
    {
        ballRb.AddForce(fireForce, ForceMode.Impulse);
        ballRb.angularVelocity = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }
}
