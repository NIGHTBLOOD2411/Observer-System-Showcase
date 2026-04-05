using UnityEngine;

public class HealthTester : MonoBehaviour
{
    public PlayerHealth playerHealth;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            playerHealth.TakeDamage(10);

        if (Input.GetKeyDown(KeyCode.H))
            playerHealth.Heal(10);
    }
}