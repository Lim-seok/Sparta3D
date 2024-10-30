using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [SerializeField] private float bounceForce = 10f;
    [SerializeField] private float minVelocity = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Vector3 bounceDirection = transform.up;
            float currentVelocity = Vector3.Dot(rb.velocity, bounceDirection);

            if (currentVelocity < minVelocity)
            {
                Vector3 bounceVelocity = bounceDirection * bounceForce;
                rb.velocity = new Vector3(rb.velocity.x, bounceVelocity.y, rb.velocity.z);
            }
            else
            {
                Vector3 bounceVelocity = bounceDirection * (currentVelocity + bounceForce);
                rb.velocity = new Vector3(rb.velocity.x, bounceVelocity.y, rb.velocity.z);
            }
        }
    }
}