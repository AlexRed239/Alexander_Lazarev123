using UnityEngine;

public class BallSync : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            Rigidbody otherRb = col.rigidbody;
            Vector3 tempVel = GetComponent<Rigidbody>().linearVelocity;

            GetComponent<Rigidbody>().linearVelocity = otherRb.linearVelocity;
            otherRb.linearVelocity = tempVel;
        }
    }
}