using UnityEngine;

public class EnergyCompensator : MonoBehaviour
{
    void FixedUpdate()
    {
        foreach (var rb in FindObjectsOfType<Rigidbody>())
        {
            if (rb.linearVelocity.magnitude < 0.1f)
            {
                rb.AddForce(rb.linearVelocity.normalized * 0.01f,
                          ForceMode.VelocityChange);
            }
        }
    }
}