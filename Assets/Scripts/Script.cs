using UnityEngine;

public class PerfectPendulumStarter : MonoBehaviour
{
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(
            new Vector3(-5f, 0, 0),
            ForceMode.VelocityChange // Резкий точный толчок
        );
    }
}